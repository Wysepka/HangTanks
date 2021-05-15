using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEngine : MonoBehaviour
{
    private float tankCurrentSpeed;
    private float currentFuel = 1f;
    private float maxFuel = 1f;

    private void Awake()
    {
        tankCurrentSpeed = StaticData.TankData.TankSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnEnable()
    {
        TankEventHandler.RegisterToTankEnginePointsIncrease(EnginePointsIncrease);
    }

    private void OnDisable()
    {
        TankEventHandler.UnRegisterToTankEnginePointsIncrease(EnginePointsIncrease);
    }

    void EnginePointsIncrease(int ammount)
    {

    }
    public float ChangeTankSpeed(float speed)
    {
        this.tankCurrentSpeed = speed;
        return tankCurrentSpeed;
    }

}
