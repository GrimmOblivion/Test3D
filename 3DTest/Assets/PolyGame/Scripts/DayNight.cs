using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour {
    public float DaySpeed = 10.0f;
    private float Timer = 0.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(Vector3.zero, Vector3.right, DaySpeed * Time.deltaTime);
        transform.LookAt(Vector3.zero);
        Timer = +Time.deltaTime;
       
	}
}
