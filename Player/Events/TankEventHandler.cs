using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TankEventHandler
{
    Tank tank;

    static UnityAction<int> tankEnginePointsIncrease;
    static UnityAction<float> tankSpeedChanged;
    

    public TankEventHandler(Tank tank)
    {
        this.tank = tank;
    }

    //----------------------------------------------------------------------------//

    public static void RegisterToTankEnginePointsIncrease(UnityAction<int> action)
    {
        tankEnginePointsIncrease += action;
    }

    public static void RegisterToTankEngineSpeedChanged(UnityAction<float> action)
    {
        tankSpeedChanged+= action;
    }

    //----------------------------------------------------------------------------//

    public static void UnRegisterToTankEnginePointsIncrease(UnityAction<int> action)
    {
        tankEnginePointsIncrease -= action;
    }

    public static void UnRegisterToTankEngineSpeedChanged(UnityAction<float> action)
    {
        tankSpeedChanged -= action;
    }

    //---------------------------------------------------------------------------//

    public void InvokeTankEnginePointsIncrease(int ammount)
    {
        if (tankEnginePointsIncrease != null) tankEnginePointsIncrease.Invoke(ammount);
    }

    public void InvokeTankEngineSpeedChanged(float speed)
    {
        if (tankEnginePointsIncrease != null) tankSpeedChanged.Invoke(speed);
    }

    //===========================================================================//

    public void ApplyTankMovement(MovementKey movementKey)
    {
        tank.TankMovement.ApplyMovement(movementKey);
    }

}
