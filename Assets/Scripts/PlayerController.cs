﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D coll) {
		Debug.Log (coll.gameObject.name);
		if (coll.gameObject.tag == "Enemy") {
			Debug.Log("die");
		}
	}
}
