using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Book : MonoBehaviour {

    public Camera Main;
    public Camera pointOfView;
    public GameObject Player;
    public bool lookingAtBook;

	// Use this for initialization
	void Start () {
        pointOfView.enabled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            Main.enabled = true;
            pointOfView.enabled = false;
            GetComponent<Animator>().Play("BookAnimationReverse");
            Player.GetComponent<FirstPersonController>().enabled = true;
            lookingAtBook = false;
        }

	}

    public void InteractOnE()
    {
        GetComponent<Animator>().Play("BookAnimation");
        pointOfView.enabled = true;
        Main.enabled = false;
        Player.GetComponent<FirstPersonController>().enabled = false;
        lookingAtBook = true;
    }
}
