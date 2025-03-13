using Mirror;
using UnityEngine;

public class NetworkBall : NetworkBehaviour
{
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        if (isServer)
        {
            // Только сервер управляет физикой мяча
            rb.isKinematic = false;
            ResetBall();
        }
    }

    [ServerCallback]
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Paddle"))
        {
            Vector3 dir = (transform.position - collision.transform.position).normalized;
            rb.AddForce(dir * 500f);
        }
    }

    [Server]
    public void ResetBall()
    {
        rb.velocity = Vector3.zero;
        transform.position = Vector3.zero;
        rb.AddForce(new Vector3(10f, 0, 10f) * 50f);
    }
}