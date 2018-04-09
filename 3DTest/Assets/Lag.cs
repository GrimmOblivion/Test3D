using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lag : MonoBehaviour {
    public int loops = 100;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        for (int i = 0; i < loops; i++) {
            Debug.Log("Pepe");
        }
	}
}
