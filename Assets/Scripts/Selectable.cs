using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public int bLayer = 9;
	// Use this for initialization
	void Start ()
    {
        bLayer = LayerMask.NameToLayer("building");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)
            {

                if (hitInfo.transform.gameObject.layer == 9)
                {
                    Debug.Log("It's working!");
                }
                else
                {
                    Debug.Log("not working");
                }
            }
        }

    }
}
