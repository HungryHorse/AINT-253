using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class ChestPush : MonoBehaviour {

    public Camera Main;
    public Camera pointOfView;
    public Light light;
    public Light playerLight;
    public GameObject player;
    public Transform startTransform;
    public Transform endTransform;
    public Transform offTrapDoor;
    public TrapDoor trapDoor;
    public AudioSource CratePush;

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

        if (pushing && Input.GetKey(KeyCode.S) && gameObject.transform.position.x > endTransform.position.x)
        {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
            if (!CratePush.isPlaying)
            {
                CratePush.Play();
            }
        }
        else if (pushing && Input.GetKey(KeyCode.W) && gameObject.transform.position.x < startTransform.position.x)
        {
            gameObject.transform.position -= Vector3.left * speed * Time.deltaTime;
            if (!CratePush.isPlaying)
            {
                CratePush.Play();
            }
        }

        if(gameObject.transform.position.x < offTrapDoor.position.x)
        {
            trapDoor.noChest = true;
        }
        else
        {
            trapDoor.noChest = false;
        }

        if (Input.GetKeyDown(KeyCode.E) && pushing)
        {
            Main.enabled = true;
            pointOfView.enabled = false;
            light.enabled = false;
            playerLight.enabled = true;
            pushing = false;
            player.GetComponent<FirstPersonController>().enabled = true;
            player.GetComponentInChildren<RaycastInteraction>().enabled = true;
            player.transform.rotation = pointOfView.transform.rotation;
        }

        if (pushing)
        {
            player.transform.position = gameObject.transform.position + new Vector3(0.1f, 1f, 0);
            player.transform.rotation = pointOfView.transform.rotation;
        }
    }
    
    public void InteractOnE()
    {
        playerLight.enabled = false;
        StartCoroutine("SetPushing");
        pointOfView.enabled = true;
        Main.enabled = false;
        player.GetComponent<FirstPersonController>().enabled = false;
        player.GetComponentInChildren<RaycastInteraction>().enabled = false;
        light.enabled = true;
    }

    public IEnumerator SetPushing()
    {
        yield return new WaitForSeconds(0.1f);
        pushing = true;
    }
}
