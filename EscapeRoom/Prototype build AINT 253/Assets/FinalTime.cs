using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalTime : MonoBehaviour
{
    public Text time;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        float timefloat =  PlayerPrefs.GetFloat("Time");
        string minuets = (Mathf.Floor(timefloat / 60)).ToString("00");
        string seconds = (timefloat % 60).ToString("00");
        time.text = "It took you: " + minuets + ":" + seconds;
    }


}
