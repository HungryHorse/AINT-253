using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour {
    public PuzzleManager puzzleManager;
    public int candleNumber;
    public AudioSource lever;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void InteractOnE()
    {
        puzzleManager.newInput(candleNumber);
        transform.parent.gameObject.GetComponent<Animator>().Play("CandleAniamtion");
        Debug.Log("Interact");
        if (!lever.isPlaying)
        {
            lever.Play();
        }
    }
}
