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

    public int magazine=15;
    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.I)&&magazine>0) {
		Instantiate (nw, nwPos.position, nwPos.rotation);
        magazine--;
				}
        else if (Input.GetKeyDown(KeyCode.O) && magazine > 0)
        {
			Instantiate (ne, nePos.position, nePos.rotation);
            magazine--;
			
		}
        else if (Input.GetKeyDown(KeyCode.L) && magazine > 0)
        {
			Instantiate (se, sePos.position, sePos.rotation);
            magazine--;
			
		}
        else if (Input.GetKeyDown(KeyCode.K) && magazine > 0)
        {
			Instantiate (sw, swPos.position, swPos.rotation);
            magazine--;
			
		}
        if (magazine<=0)
        {
            StartCoroutine("Reload");
        }
		//		this.transform.position =new Vector3(this.transform.position.x,this.transform.position.y,this.transform.position.z);

	}
    IEnumerator Reload() {
        yield return new WaitForSeconds(2f);
        magazine = 15;
    }
}
