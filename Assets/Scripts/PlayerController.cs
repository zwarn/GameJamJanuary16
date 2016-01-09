using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnCollisionEnter2D(Collision2D coll) {
		//die
		if (coll.gameObject.tag == "Enemy") {
			transform.position = new Vector3 (0, 0, 0);
		}
	}
}
