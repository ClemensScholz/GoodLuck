using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Luck : MonoBehaviour
{
    public int maxLuck;
    private int playerLuck;

    void Start()
    {
        playerLuck = maxLuck;
    }

    IEnumerator addLuck()
    {
        while (true)
        {
            if (playerLuck <= maxLuck)
            {
                if (maxLuck - playerLuck >= 10)
                {
                    playerLuck += 10;   
                }
                else
                {
                    playerLuck += maxLuck - playerLuck;
                }
            }
            yield return new WaitForSeconds(1);   
        }
    }

    public void reduceLuck()
    {
        playerLuck -= 25;
        if (playerLuck <= 0)
        {
            Scene s = SceneManager.GetActiveScene();
            SceneManager.LoadScene(s.name);
        }
    }
}
