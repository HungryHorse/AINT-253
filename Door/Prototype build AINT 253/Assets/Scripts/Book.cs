using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Book : MonoBehaviour {

    public Camera Main;
    public Camera pointOfView;
    public GameObject Player;
    public bool lookingAtBook = false;
    public KeyPad keyPad;
    public Light light;
    public Light playerLight;

	// Use this for initialization
	void Start () {
        pointOfView.enabled = false;
        Player.SetActive(true);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.E) && lookingAtBook)
        {
            Player.SetActive(true);
            Main.enabled = true;
            pointOfView.enabled = false;
            GetComponent<Animator>().Play("BookAnimationReverseMobyDick");
            Player.GetComponent<FirstPersonController>().enabled = true;
            lookingAtBook = false;
            keyPad.DiableKeyPad();
            light.enabled = false;
            playerLight.enabled = true;
        }
    }

    public void InteractOnE()
    {
        Player.SetActive(false);
        Debug.Log("Interact");
        GetComponent<Animator>().Play("BookAnimationMobyDick");
        pointOfView.enabled = true;
        Main.enabled = false;
        Player.GetComponent<FirstPersonController>().enabled = false;
        light.enabled = true;
        StartCoroutine("LookingAtBook");
        playerLight.enabled = false;
    }

    public IEnumerator LookingAtBook()
    {
        yield return new WaitForSeconds(0.1f);
        lookingAtBook = true;
    }

    public void bookHasArrived()
    {
        keyPad.KeyPadShouldBeActive = true;
        keyPad.StartCoroutine("ActivateKeyPad");
    }
}
