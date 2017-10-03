using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teste : MonoBehaviour {
	public bool states;

	// Use this for initialization
	void Start () {
		states = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision colisor){
		if (states) {
			printa ();
			states = !states;
		}
	}

	void printa (){
		print ("Tocou");
	}
}
