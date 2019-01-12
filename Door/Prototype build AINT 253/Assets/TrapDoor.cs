using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour {

    public bool hasKey;
    public bool noChest;
    public Animator trapDoorAnim;
    public Animator keyAnim;
    public GameObject Key;
    public AudioSource creakingTrapDoor;

    private bool allreadyUsed;


    public void InteractOnE()
    {
        if(hasKey && noChest && !allreadyUsed)
        {
            allreadyUsed = true;
            Key.SetActive(true);
            Key.GetComponent<Rigidbody>().isKinematic = true;
            Key.transform.localPosition = Key.GetComponent<Key>().localPos;
            Key.transform.GetChild(0).transform.localPosition = Key.GetComponent<Key>().childLocalPos;
            keyAnim.Play("Key");
        }
    }

    public void OpenTrapDoor()
    {
        Key.SetActive(false);
        trapDoorAnim.Play("TrapDoor");
        creakingTrapDoor.Play();
    }
}
