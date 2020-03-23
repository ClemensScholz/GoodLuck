using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            restartCurrent();   
        }
    }

    void restartCurrent()
    {
        Scene s = SceneManager.GetActiveScene();
        SceneManager.LoadScene(s.name);
    }
}
