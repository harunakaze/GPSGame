using UnityEngine;
using System.Collections;

public class CameraMove : MonoBehaviour {

	// Use this for initialization
//	public TouchJoystick joystick;
	[Range(-1.0f, 1.0f)]
	public float backwardThreshold = 0.0f;
	
	public Transform target;
	public float backDistance = 10.0f;
	public float smooth = 5.0f;
	
	private Vector3 offset;
	private Vector3 backOffset;
	private Vector2 movement; 
	
	void Start() {
		offset = transform.position - target.position;
	}
	
	void Update() {
	}
	
	void FixedUpdate() {
        if (target == null)
            return;

		Vector3 targetOffset = offset;
		Vector3 finalPosition = target.position + targetOffset;
		
		transform.position = Vector3.Lerp(transform.position, finalPosition, smooth * Time.deltaTime);
	}
}
