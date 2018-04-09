using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerToVehicle : MonoBehaviour {
    public GameObject Player;
    public GameObject Car;
    public GameObject Plane;
    public Vector3 startPos;
    public bool player = false;
    public bool plane = false;
    public bool car = false;

    // Use this for initialization
    void Start () {
        startPos = transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.E) || car == true)
        {
            Car.SetActive(true);
            Plane.SetActive(false);
            Player.SetActive(false);
            player = false;
            plane = false;
            car = false;
        }
        if (Input.GetKeyDown(KeyCode.R) || player == true)
        {
            
            Car.SetActive(false);
            Plane.SetActive(false);
            Player.SetActive(true);
            car = false;
            plane = false;
            player = false;
        }
        if (Input.GetKeyDown(KeyCode.F) || plane == true)
        {
            Car.SetActive(false);
            Plane.SetActive(true);
            Player.SetActive(false);
            car = false;
            player = false;
            plane = false;
        }
        if (Input.GetKeyDown(KeyCode.Q)) {
            transform.position = startPos;
        }
    }
}
