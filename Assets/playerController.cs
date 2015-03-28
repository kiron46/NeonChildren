using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {

	//Speed modifier
	public float speed;
	//horizontal input
	float h;
	//Vertical Input
	float v;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.Rigidbody2D.AddForce(vector2.right * h);
		gameObject.Rigidbody2D.AddForce(vector2.up * v);
	}
}
