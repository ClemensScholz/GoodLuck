using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public int nextLvl;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            if (nextLvl != 0)
            {
                if (nextLvl > PlayerPrefs.GetInt("levelReached", 1))
                {
                    PlayerPrefs.SetInt("levelReached", nextLvl);
                }
            }
        }
    }
}
