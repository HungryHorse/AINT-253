using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastInteraction : MonoBehaviour {

    public Texture2D crosshair;
    private Rect position;
    bool hitting = false;

	// Use this for initialization
	void Start ()
    {
        crosshair = Texture2D.whiteTexture;
	}
	
	// Update is called once per frame
	void Update ()
    {
        position = new Rect((Screen.width - crosshair.width) / 2, (Screen.height - crosshair.height) / 2, crosshair.width, crosshair.height);
        RaycastHit hit;

		if(Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, 1))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            hitting = true;
        }
        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            hitting = false;
        }
        if (hitting)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                if (hit.transform.gameObject.tag == "Interactable" && Vector3.Distance(hit.transform.position, transform.position) < 10)
                {
                    hit.transform.gameObject.SendMessage("Interact");
                    Debug.Log("Clicked");
                }
            }
            if (Input.GetKeyDown(KeyCode.E))
            {
                if (hit.transform.gameObject.tag == "Interactable" && Vector3.Distance(hit.transform.position, transform.position) < 10)
                {
                    hit.transform.gameObject.SendMessage("InteractOnE");
                    Debug.Log("PressedE");
                }
            }
        }
    }

    private void OnGUI()
    {
        GUI.DrawTexture(position, crosshair);
    }


}
