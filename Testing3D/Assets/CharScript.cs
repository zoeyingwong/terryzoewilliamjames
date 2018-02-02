using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharScript : MonoBehaviour {

	Animator animChar;
	Rigidbody mainChar;

	// Use this for initialization
	void Start () {
		mainChar = GetComponent<Rigidbody> ();
		animChar = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			mainChar.AddForce(new Vector3(0,0,5), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.forward);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			mainChar.AddForce(new Vector3(0,0,5), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.forward);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			mainChar.AddForce(new Vector3(-5,0,0), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.left);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			mainChar.AddForce(new Vector3(5,0,0), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.right);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			mainChar.AddForce(new Vector3(0,0,-5), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.back);
		}
			
	}

	void FixedUpdate(){

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			mainChar.AddForce(new Vector3(0,0,5), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.forward);
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			mainChar.AddForce(new Vector3(0,0,5), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.forward);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			mainChar.AddForce(new Vector3(-5,0,0), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.left);
		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			mainChar.AddForce(new Vector3(5,0,0), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.right);
		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			mainChar.AddForce(new Vector3(0,0,-5), ForceMode.VelocityChange);
			mainChar.rotation = Quaternion.LookRotation (Vector3.back);
		}
	}
}
