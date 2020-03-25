using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public int numLevel;
    private void Start()
    {
        Cursor.visible = true;
    }

    public void PlayGame()
    {
        int l = PlayerPrefs.GetInt("levelReached", 1);
        if (l <= numLevel)
        {
            SceneManager.LoadScene(l + 1);
        }
        else
        {
            SceneManager.LoadScene(1);
        }
       
    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(1);
    }
    
    public void RestartGame()
    {
        SceneManager.LoadScene(2);
        PlayerPrefs.DeleteAll();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoLevels()
    {
        SceneManager.LoadScene(1);
    }

    public void GoMenu()
    {
        SceneManager.LoadScene(0);
    }
}
