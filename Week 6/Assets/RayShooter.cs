using UnityEngine;
using System.Collections;

public class RayShooter : MonoBehaviour {

	public float rayDistance = 5;
	
	// Use this for initialization
	void Start () {
		print ("howdy");
		Debug.Log ("yes this is a greeting");
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast (ray, out hit)) {
				RaycastHit hitInfo;
				if (Physics.Raycast (transform.position, transform.forward, out hitInfo, rayDistance)) {
					hitInfo.collider.GetComponent<cycleTextures> ().changeTexture ();
				}
			}
		}
	}
	void OnDrawGizmos(){
		Gizmos.color = Color.red;
		Gizmos.DrawRay (transform.position, transform.forward * rayDistance);
	}
}
