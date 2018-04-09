using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateThis : MonoBehaviour {

    // Use this for initialization
    public float RotationSpeed = 0;
    public float xRotate = 0;
	public float yRotate = 0;
    public float zRotate = 0;
    public bool xMove = false;
    public bool yMove = false;
    public bool zMove = false;
    public bool RandomTrue = false;

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (RandomTrue)
        {
            float RotationSpeed = Random.Range(1, 5);
            xRotate = RotationSpeed;
            yRotate = RotationSpeed;
            zRotate = RotationSpeed;
        }
        if (zMove == true)
        {
            zRotate = RotationSpeed;
        }
        if (xMove == true)
        {
            transform.Translate(0.001f * RotationSpeed, 0, 0);
        }
        if (yMove == true)
        {
            transform.Translate(0, 0.001f * RotationSpeed, 0);
        }
        transform.Rotate (xRotate, yRotate, zRotate * Time.deltaTime);
        }
    }

