using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDebris : MonoBehaviour {

    private Transform transform;
    public float moveZ;

    private void Start()
    {
        transform = gameObject.transform;
    }

    void Update () {
        transform.position += new Vector3(0, 0, moveZ);
	}
}
