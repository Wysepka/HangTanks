using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleV1 : Obstacle
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {
        //base.Update();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.gameObject.layer == LayerMask.NameToLayer("Tank"))
        {
            Debug.Log("Collided tank");
        }
    }

    /*
    protected override IEnumerator<float> ApplyObstacleMovement()
    {
        base.ApplyObstacleMovement();
    }
    */
}
