using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoad : MonoBehaviour
{
    public int lvl;

    public void GoToLevel()
    {
        SceneManager.LoadScene(lvl);
    }
}
