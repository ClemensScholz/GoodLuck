using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Luck : MonoBehaviour
{
    public int maxLuck;
    private int playerLuck;

    public LuckBar luckbar;

    void Start()
    {
        playerLuck = maxLuck;
        luckbar.SetMaxLuck(maxLuck);
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
                luckbar.SetLuck(playerLuck);
            }
            yield return new WaitForSeconds(1);   
        }
    }

    public void reduceLuck()
    {
        playerLuck -= 25;
        luckbar.SetLuck(playerLuck);
        if (playerLuck <= 0)
        {
            Scene s = SceneManager.GetActiveScene();
            SceneManager.LoadScene(s.name);
        }
    }
}
