using UnityEngine;
using System.Collections;

public class PlayerShoot : MonoBehaviour {
	public GameObject nw;
	public GameObject sw;
	public GameObject ne;
	public GameObject se;

    public Transform nwPos;
    public Transform swPos;
    public Transform nePos;
    public Transform sePos;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.I)) {
		Instantiate (nw, nwPos.position, nwPos.rotation);
			
				}
		else if (Input.GetKeyDown(KeyCode.O)) {
			Instantiate (ne, nePos.position, nePos.rotation);
			
		}
		else if (Input.GetKeyDown(KeyCode.L)) {
			Instantiate (se, sePos.position, sePos.rotation);
			
		}
		else if (Input.GetKeyDown(KeyCode.K)) {
			Instantiate (sw, swPos.position, swPos.rotation);
			
		}
		//		this.transform.position =new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);

	}
}
