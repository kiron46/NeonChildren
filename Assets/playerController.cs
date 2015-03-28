using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	//Speed modifier
	public float speed = 10;
	//horizontal input
	float h;
	//Vertical Input
	float v;
	//The Player number for 
	public int playerNum;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Get the horizontal and vertical inputs
		//positive = 1, negative = -1, no input = 0;
		h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("Vertical");
		//add forces to the player based on these inputs
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.right * h * speed);
		gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * v * speed);
	}
}
