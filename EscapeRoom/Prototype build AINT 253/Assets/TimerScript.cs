using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

    public float time;
    public Text timeText;
    public bool Stopped;

    private void Update()
    {
        if (!Stopped)
        {
            time += Time.deltaTime;
        }

        string minuets = (Mathf.Floor(time / 60)).ToString("00");
        string seconds = (time % 60).ToString("00");

        timeText.text = minuets + ":" + seconds;
    }

    public void Stop()
    {
        Stopped = true;
    }
}
