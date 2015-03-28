using UnityEngine;
using System.Collections;

public class hurtOther : MonoBehaviour {
	public int damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D (Collider2D other) {
		other.gameObject.GetComponent<health>().hurtMe(damage);
	}
}
