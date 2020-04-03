using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    
    public void OpenScene()
    {
        SceneManager.LoadScene("Camera");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
