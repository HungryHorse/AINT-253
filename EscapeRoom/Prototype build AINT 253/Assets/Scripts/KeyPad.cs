using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour {

    public GameObject keyPad;
    public Text Output1;
    public Text Output2;
    public Text Output3;
    public Text Output4;
    public bool KeyPadShouldBeActive;
    public Animator doorAnimator;
    public GameObject Note;
    public GameObject CodeText;

    public int[] code;
    private bool compeleted;
    private int[] InputedCode = new int[4];
    private int inputs = 0;
    private bool correctInput;

    private void Start()
    {
        Cursor.visible = true;
    }

    public void AddNumber(int numberInput)
    {
        if (!compeleted)
        {
            switch (inputs)
            {
                case 0:
                    Output1.text = numberInput.ToString();
                    InputedCode[0] = numberInput;
                    break;
                case 1:
                    InputedCode[1] = InputedCode[0];
                    InputedCode[0] = numberInput;
                    Output1.text = InputedCode[0].ToString();
                    Output2.text = InputedCode[1].ToString();
                    break;
                case 2:
                    InputedCode[2] = InputedCode[1];
                    InputedCode[1] = InputedCode[0];
                    InputedCode[0] = numberInput;
                    Output1.text = InputedCode[0].ToString();
                    Output2.text = InputedCode[1].ToString();
                    Output3.text = InputedCode[2].ToString();
                    break;
                case 3:
                    InputedCode[3] = InputedCode[2];
                    InputedCode[2] = InputedCode[1];
                    InputedCode[1] = InputedCode[0];
                    InputedCode[0] = numberInput;
                    Output1.text = InputedCode[0].ToString();
                    Output2.text = InputedCode[1].ToString();
                    Output3.text = InputedCode[2].ToString();
                    Output4.text = InputedCode[3].ToString();
                    for (int i = 0; i < 4; i++)
                    {
                        if (code[i] != InputedCode[i])
                        {
                            StartCoroutine("ResetInputs");
                            return;
                        }
                    }
                    StartCoroutine("Open");
                    compeleted = true;
                    break;
            }
            inputs++;
        }
    }

    public IEnumerator Open()
    {
        Output1.color = Color.green;
        Output2.color = Color.green;
        Output3.color = Color.green;
        Output4.color = Color.green;
        yield return new WaitForSeconds(0.5f);
        keyPad.SetActive(false);
        doorAnimator.Play("GetNote");
        yield return new WaitForSeconds(0.5f);
        Destroy(Note);
        CodeText.SetActive(true);
    }

    public IEnumerator ResetInputs()
    {
        inputs = 0;
        InputedCode = new int[4];
        Output1.color = Color.red;
        Output2.color = Color.red;
        Output3.color = Color.red;
        Output4.color = Color.red;
        yield return new WaitForSeconds(1);
        Output1.text = "";
        Output2.text = "";
        Output3.text = "";
        Output4.text = "";
        Output1.color = Color.white;
        Output2.color = Color.white;
        Output3.color = Color.white;
        Output4.color = Color.white;
    }

    public IEnumerator ActivateKeyPad()
    {
        yield return new WaitForSeconds(1);
        keyPad.SetActive(KeyPadShouldBeActive);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void DiableKeyPad()
    {
        KeyPadShouldBeActive = false;
        keyPad.SetActive(KeyPadShouldBeActive);
    }
}
