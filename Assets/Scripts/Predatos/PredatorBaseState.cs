using UnityEngine;

[RequireComponent(typeof(PredatorEngine))]
public abstract class PredatorBaseState : MonoBehaviour, IPredatorState {

    protected PredatorEngine pEngine { get; private set; }
    protected MonoBehaviour pData;

    void Awake() {
        pEngine = GetComponent<PredatorEngine>();
        pData = pEngine.predatorData;
    }

    public virtual void SEnter() { }

    public virtual void SExit() { }

    public virtual void SUpdate() { }

    public virtual void SFixedUpdate() { }

    public virtual void SOnCollisionEnter(Collision other) { }

    public virtual void SOnTriggerEnter(Collider other) { }

    public virtual void SOnCollisionEnter2D(Collision2D other) { }
}
