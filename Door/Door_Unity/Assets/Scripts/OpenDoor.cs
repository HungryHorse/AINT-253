using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour {

    private Animator anim;
    public bool active = false;
    public MoveDebris move;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update () {
		if(Input.GetKeyDown(KeyCode.E) && active)
        {
            anim.SetBool("StartAnim", true);
        }
	}

    private void OnTriggerStay(Collider other)
    {
        active = true;
    }

    private void OnTriggerExit(Collider other)
    {
        active = false;
    }
}
