using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform playerTank;
    
    void FixedUpdate()
    {
        transform.position = new Vector3(playerTank.position.x, transform.position.y, transform.position.z);
    }
}
