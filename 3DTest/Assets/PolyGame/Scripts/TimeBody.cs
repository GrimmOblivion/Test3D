using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//12:37 REWIND TIME in unity Brackeys
public class TimeBody : MonoBehaviour {

    public bool isRewinding = false;

    List<PointInTime> PointInTime;

    Rigidbody rb;

	// Use this for initialization
	void Start () {
        PointInTime = new List<PointInTime>();
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.X)) {
            StartRewind();
        }
        if (Input.GetKeyUp(KeyCode.X))
        {
            StopRewind();
        }
    }

    void FixedUpdate()
    {
        if (isRewinding)
        {

        }
        else {
            Record();
        }
    }
    void Rewind() {
        if (PointInTime.Count > 0)
        {

            PointInTime pointInTime = pointInTime[0];
            transform.position = pointInTime.posision;
            transform.rotation = pointInTime.rotation;
            PointInTime.RemoveAt(0);
        }
        else {
            StopRewind();
        }

    }
    void Record()
    {
        if (PointInTime.Count > Mathf.Round(5f / Time.fixedDeltaTime)) {

        }
        PointInTime.Insert(0, new PointInTime(transform.position, transform.rotation));
    }

    public void StartRewind() {
        isRewinding = true;
        rb.isKinematic = true;
    }
    public void StopRewind() {
        isRewinding = false;
        rb.isKinematic = false;
    }
}
