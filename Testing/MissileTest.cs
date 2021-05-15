using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileTest : MonoBehaviour
{

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("DelayDestroy", 4f);
    }

    public void LaunchMissile()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(this.transform.forward * 200f);
    }

    void DelayDestroy()
    {
        Destroy(gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
        }
    }
}
