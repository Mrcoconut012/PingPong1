using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class New_BallC : MonoBehaviour
{
    public float pushForce = 10f;
    public Rigidbody rb;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "otb")
        { 
            Vector3 normal = collision.contacts[0].normal;
            rb.AddForce(-normal * pushForce);
        }
    }
}
