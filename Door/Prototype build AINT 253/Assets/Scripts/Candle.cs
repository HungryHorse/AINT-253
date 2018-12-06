using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candle : MonoBehaviour {
    public PuzzleManager puzzleManager;
    public int candleNumber;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void Interact()
    {
        puzzleManager.newInput(candleNumber);
        GetComponent<Animator>().Play("CandleAniamtion");
        Debug.Log("Interact");
    }
}
