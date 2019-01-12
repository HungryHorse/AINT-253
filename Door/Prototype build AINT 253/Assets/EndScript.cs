using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScript : MonoBehaviour {

    public TimerScript timer;
    public SceneScript scene;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            PlayerPrefs.SetFloat("Time", timer.time);
            Debug.Log(timer.time);
            StartCoroutine("wait");
        }
    }

    public IEnumerator wait()
    {
        yield return new WaitForSeconds(0.1f);
        scene.Win();
    }
}
