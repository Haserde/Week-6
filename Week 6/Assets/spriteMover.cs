using UnityEngine;
using System.Collections;

public class spriteMover : MonoBehaviour {

	Animator spriteController;

	// Use this for initialization
	void Start () {
		spriteController = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow) ) { 
			spriteController.SetInteger ("State", 0);
		} else if  (Input.GetKey (KeyCode.UpArrow) ){
			spriteController.SetInteger("State", 1);
		}
	}
}
