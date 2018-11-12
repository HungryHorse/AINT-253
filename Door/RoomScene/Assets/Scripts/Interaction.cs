using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour {

    public bool hovered;
    public GameObject Text;
    public AudioSource drawer;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && hovered)
        {
            gameObject.GetComponent<Animator>().SetBool("Move", true);
            drawer.Play();
        }

        
    }

    private void OnTriggerStay(Collider other)
    {
        hovered = true;
        Text.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        hovered = false;
        Text.SetActive(false);
    }
}
