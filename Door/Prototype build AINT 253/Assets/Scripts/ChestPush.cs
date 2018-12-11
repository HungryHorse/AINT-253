using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ChestPush : MonoBehaviour {

    public Camera Main;
    public Camera pointOfView;
    public GameObject player;
    public Transform startTransform;
    public Transform endTransform;

    [SerializeField]
    private float speed;
    
    private bool pushing;

	// Use this for initialization
	void Start ()
    {
        pushing = false;	
	}
	
	// Update is called once per frame
	void Update () {

        if (pushing && Input.GetKey(KeyCode.S) && gameObject.transform.position.z > startTransform.position.z)
        {
            gameObject.transform.position += Vector3.back * speed * Time.deltaTime;
        }
        else if (pushing && Input.GetKey(KeyCode.W) && gameObject.transform.position.z < endTransform.position.z)
        {
            gameObject.transform.position -= Vector3.back * speed * Time.deltaTime;
        }


        if (Input.GetKeyDown(KeyCode.E) && pushing)
        {

            Main.enabled = true;
            pointOfView.enabled = false;
            pushing = false;
            player.GetComponent<FirstPersonController>().enabled = true;
        }

        if (pushing)
        {
            player.transform.position = gameObject.transform.position + new Vector3(0, 1f, -2.5f);
        }
    }
    
    public void InteractOnE()
    {
        pushing = true;
        pointOfView.enabled = true;
        Main.enabled = false;
        player.GetComponent<FirstPersonController>().enabled = false;
    }

}
