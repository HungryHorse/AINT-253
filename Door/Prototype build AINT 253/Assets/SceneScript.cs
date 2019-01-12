using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public void EscapeRoom()
    {
        SceneManager.LoadScene("Room");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Win()
    {
        SceneManager.LoadScene("Win");
    }
    public void Credits()
    {
        SceneManager.LoadScene("Credits");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
