using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pew_Pew : MonoBehaviour {

	public GameObject bullet_Prefab;
	private bool Mouse_Pressed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if((Input.GetKey (KeyCode.Space))){
			print("Success");
			Mouse_Pressed = true;
		}
		else {
			Mouse_Pressed = false;

		}

	}

	void FixedUpdate(){
		//Apply Physics
		if (Mouse_Pressed == true) {
			Instantiate (bullet_Prefab, gameObject.transform.position, gameObject.transform.rotation);
		}

		



	


	
	}
}
