using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
    public int[] correctInput;
    int correctInputs = 0;
    int currIndex = 0;
    public bool puzzleSolved;
    public Rigidbody keyRb;
    public AudioSource KeyDispenser;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (puzzleSolved)
        {
            if (keyRb != null)
            {
                keyRb.isKinematic = false;
            }
        }
    }

    public void newInput(int candle)
    {
        if (candle == correctInput[currIndex])
        {
            correctInputs++;
            currIndex++;
            Debug.Log(correctInputs);
        }
        else
        {
            currIndex = 0;
            correctInputs = 0;
        }
        if (correctInputs == correctInput.Length)
        {
            puzzleSolved = true;
            KeyDispenser.Play();
        }
    }
}
