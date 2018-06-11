using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject flyCamera;
    public GameObject g;

	// Use this for initialization
	void Start ()
    {
        mainCamera.enabled = true;
        flyCamera.SetActive(false);
        
       
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            flyCamera.SetActive(true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            flyCamera.SetActive(false);
        }
	}
}
