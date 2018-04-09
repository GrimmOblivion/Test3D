using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapLevels : MonoBehaviour
{
    public bool IsWin = false;
    // Use this for initialization
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (IsWin == true) {
            SceneManager.LoadScene("WinLvl");

        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "WIN")
        {
            SceneManager.LoadScene("WinLvl");
            Debug.Log("HIT!");
        }
        Debug.Log(collision.gameObject.name);

    }
}
