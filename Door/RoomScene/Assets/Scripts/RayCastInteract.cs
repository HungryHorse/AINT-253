using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastInteract : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;

        if (Physics.Raycast(transform.position, Camera.main.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            if (hit.transform.gameObject.tag == "Interact")
            {
                Debug.Log("Has Tag");
                hit.transform.gameObject.GetComponent<Interaction>().hovered = true;
            }
        }

    }

    
}
