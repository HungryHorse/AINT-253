using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject Code;
    public GameObject KeyText;
    public TrapDoor trapDoor;
    public Vector3 localPos;
    public Vector3 childLocalPos;

    private void Start()
    {
        localPos = transform.localPosition;
        childLocalPos = GetComponentInChildren<Transform>().localPosition; 
    }

    public void InteractOnE()
    {
        gameObject.SetActive(false);
        KeyText.SetActive(true);
        Code.SetActive(false);
        trapDoor.hasKey = true;
    }
}
