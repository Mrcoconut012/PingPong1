using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCheck : MonoBehaviour
{
    public GameObject Floor;
    public GameObject ball;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name ==  Floor.name)
        {
            Debug.Log("123");
            Destroy(this.gameObject);
        }
    }
}
