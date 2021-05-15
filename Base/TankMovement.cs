using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{
    protected Tank tank;
    protected TankEngine tankEngine;
    protected MapHandler mapHandler;

    protected void Awake()
    {
        if (GetComponent<TankEngine>()) tankEngine = GetComponent<TankEngine>();
        else tankEngine = gameObject.AddComponent<TankEngine>();

        tank = GetComponent<Tank>();
        mapHandler = FindObjectOfType<MapHandler>();
    }

    // Start is called before the first frame update
    protected void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void ApplyMovement(MovementKey movementKey)
    {

    }

    public virtual void ChangeTankSpeed(float speed)
    {
        tank.EventHandler.InvokeTankEngineSpeedChanged(tankEngine.ChangeTankSpeed(speed));
    }

    public virtual void UpdatePosition(Vector3 newPos)
    {
        this.transform.position = newPos;
    }

}
