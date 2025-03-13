using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballC : MonoBehaviour
{
    public float forceMultipier = 10f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();

    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ballp(Vector3.forward);
        }

    }
    void ballp(Vector3 direction)
    {
        Vector3 force  = direction.normalized * forceMultipier * Time.deltaTime;
        rb.AddForce(force); 
    }
}
