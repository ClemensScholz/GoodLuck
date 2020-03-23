using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reload : MonoBehaviour
{
    private Coroutine co;
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            StartReload(other);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("exit");
            EndReload(other);
        }
    }

    void StartReload(Collider2D other)
    {
        co = other.GetComponent<Luck>().StartCoroutine("addLuck");
    }
    
    void EndReload(Collider2D other)
    {
        other.GetComponent<Luck>().StopCoroutine(co);
    }
}
