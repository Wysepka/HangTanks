using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
    protected Obstacle obstacle;

    protected Rigidbody rb;
    protected Collider coll;

    protected void Awake()
    {
        obstacle = GetComponentInParent<Obstacle>();
        rb = GetComponent<Rigidbody>();
        coll = GetComponent<Collider>();
        coll.isTrigger = true;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousSpeculative;
        //rb.isKinematic = false;
    }

    // Start is called before the first frame update
    protected void Start()
    {
        
    }

    // Update is called once per frame
    protected void Update()
    {
        
    }

    protected virtual void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Tank"))
        {
            //this.gameObject.SetActive(false);
        }
    }

    protected virtual void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Tank"))
        {
            //this.gameObject.SetActive(false);
            coll.isTrigger = false;
            rb.useGravity = true;
            rb.isKinematic = false;

        }
    }
}
