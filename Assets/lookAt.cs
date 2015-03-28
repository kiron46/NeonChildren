using UnityEngine;
using System.Collections;

public class lookAt : MonoBehaviour {
float h;
		float v;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		h = Input.GetAxis(transform.parent.GetComponent<playerControllerMovement>().playerNum + "_h");
		v = Input.GetAxis(transform.parent.GetComponent<playerControllerMovement>().playerNum + "_v");
		//add forces to the player based on these inputs

		//Aim player at mouse
		//which direction is up
		Vector3 upAxis = new Vector3(0,0,-1);

		Vector3 axisDirection = new Vector3 (h, v, 0);
		transform.LookAt(axisDirection, upAxis);
		//zero out all rotations except the axis I want
		transform.eulerAngles = new Vector3(0,0,transform.eulerAngles.z);

	}
}
