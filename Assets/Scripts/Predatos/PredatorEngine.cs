using System;
using System.Collections.Generic;
using UnityEngine;

public class PredatorEngine : MonoBehaviour {
    public PredatorBaseState firstState;
    public MonoBehaviour predatorData;

    private Dictionary<Type, IPredatorState> stateList = new Dictionary<Type, IPredatorState>();

    private IPredatorState currentState = null;
    private IPredatorState nextState = null;

    private bool exitCurrentState = false;
    private bool enterNextState = true; // First enter always true.

    void Awake() {
        GetStates();
        SetFirstState();
    }

    void GetStates() {
        IPredatorState[] states = GetComponents<IPredatorState>();
       
        foreach (IPredatorState state in states) {
            Type stateType = state.GetType();
            stateList.Add(stateType, state);
        }  
    }

    void SetFirstState() {
        currentState = stateList[firstState.GetType()];

        if (currentState == null)
            Debug.LogError("NO FIRST STATE DEFINED!");
    }

    public void AddState<T>() where T : IPredatorState {
        Type stateType = typeof(T);
        Component newState = gameObject.AddComponent(typeof(T));

        stateList.Add(stateType, (IPredatorState)newState);
    }

    public void SwitchState<T>(bool addIfNull = false) where T : IPredatorState {
        IPredatorState targetState = null;

        try {
            targetState = stateList[typeof(T)];
        }
        catch (KeyNotFoundException e) {
            Debug.LogError("WRONG STATE! " + e);

            if (addIfNull) {
                if (!stateList.ContainsKey(typeof(T))) {
                    AddState<T>();

                    targetState = stateList[typeof(T)];
                }
            }
        }
        finally {
            if (targetState != null) {
                nextState = targetState;
                exitCurrentState = true;
            }
        }
    }

    void ProcessStateChange() {
        currentState = nextState;
    }

    void StateUpdate() {
        if (exitCurrentState) {
            currentState.SExit();

            exitCurrentState = false;
            enterNextState = true;

            ProcessStateChange();
        }

        if (enterNextState) {
            currentState.SEnter();

            enterNextState = false;
        }

        currentState.SUpdate();
    }

    void Update() {
        StateUpdate();
    }

    void FixedUpdate() {
        currentState.SFixedUpdate();
    }

    void OnCollisionEnter(Collision other) {
        currentState.SOnCollisionEnter(other);
    }

    void OnTriggerEnter(Collider other) {
        currentState.SOnTriggerEnter(other);
    }
}
