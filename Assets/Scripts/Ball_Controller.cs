using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    
    public float speed = 1.0f;
    public string axis = "Vertical";
    public float bounceForce = 15.0f;
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name== "ball")
        {
            Vector3 contactPoint = collision.contacts[0].normal;
            float difference = contactPoint.y - transform.position.y;
            float normalizedDifference = difference / (GetComponent<Collider>().bounds.size.y / 2);
            Vector3 direction = new Vector3(1,normalizedDifference, 0).normalized;

            Rigidbody ballRb = collision.gameObject.GetComponent<Rigidbody>();
            if (ballRb != null)
            {
                ballRb.velocity = Vector3.zero;
                ballRb.AddForce(direction * bounceForce, ForceMode.Impulse);
            }
        }
    }

}
