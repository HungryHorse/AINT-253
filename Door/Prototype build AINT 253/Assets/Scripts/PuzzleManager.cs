using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
    public int[] correctInput;
    int correctInputs = 0;
    int currIndex = 0;
    public bool puzzleSolved;
    public Material completedMat;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (puzzleSolved)
        {
            completedMat.SetColor("_Color", Color.green);
        }
        else
        {
            completedMat.SetColor("_Color", Color.red);
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
        }
        if (correctInputs == correctInput.Length)
        {
            puzzleSolved = true;
            completedMat.SetColor("_Color", Color.green);
        }
    }
}
