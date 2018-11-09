using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class outOfDoor : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        End();
    }

    public void End()
    {
        SceneManager.LoadScene(1);
    }
}
