using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    [SerializeField] private Rigidbody rbb;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            rbb.AddForce(rbb.transform.up * 10000f);
        }
        
    }
}
