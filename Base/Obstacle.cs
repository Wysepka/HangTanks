using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MEC;

public class Obstacle : MonoBehaviour
{
    protected ObstacleEventHandler eventHandler;

    protected float speed = 0.05f;
    protected Vector3 vectorToMove = Vector3.forward * -1f;
    protected Vector2 treesholdDisableDestroy = new Vector2(3f, 3f);

    protected int obstacleID = 0;
    static int obstacleIDCounter = 0;

    private void Awake()
    {
        eventHandler = new ObstacleEventHandler();
        obstacleID = obstacleIDCounter;
        obstacleIDCounter++;
    }

    // Start is called before the first frame update
    protected void Start()
    {
        Timing.RunCoroutine(ApplyObstacleMovement().CancelWith(gameObject));
        Timing.RunCoroutine(DisableObstacleDelayed(10f).CancelWith(gameObject));
    }

    protected virtual IEnumerator<float> ApplyObstacleMovement()
    {
        //yield return Timing.DeltaTime;

        while (gameObject.activeSelf)
        {
            yield return Timing.WaitForOneFrame;
            this.transform.position += vectorToMove * StaticData.TankData.CurrentTankSpeed;
        }
    }

    protected virtual IEnumerator<float> DisableObstacleDelayed(float delay)
    {
        yield return Timing.WaitForSeconds(delay);
        //this.gameObject.SetActive(false);
        Destroy(this.gameObject);
    }

    protected virtual void DisableObstacleInstant()
    {

    }

}
