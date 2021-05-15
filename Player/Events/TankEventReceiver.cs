using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankEventReceiver
{
    TankEventHandler eventHandler;

    public TankEventReceiver(TankEventHandler eventHandler)
    {
        this.eventHandler = eventHandler;
    }
    
    public void RegisterToIncomingEvents()
    {
        KeysEventHandler.RegisterToKeywordTyped(RegisterToWordTyped);
        InputEventHandler.RegisterToMovementKeyPressed(RegisterToMovementApplied);
    }

    public void UnRegisterToIncomingEvents()
    {
        KeysEventHandler.UnRegisterToKeywordTyped(RegisterToWordTyped);
        InputEventHandler.UnRegisterToMovementKeyPressed(RegisterToMovementApplied);
    }

    //--------------------------------------------------------------------//

    public void RegisterToWordTyped(KeyResultV1 action)
    {
        float typedWordPercentage = (float)action.CharsTypedCorrectly / (float)action.CharsTotal;

        if(typedWordPercentage>0.5f) eventHandler.InvokeTankEnginePointsIncrease(1);
    }

    public void RegisterToMovementApplied(MovementKey movementKey)
    {
        this.eventHandler.ApplyTankMovement(movementKey);
    }

}
