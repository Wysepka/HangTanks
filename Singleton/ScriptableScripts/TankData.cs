using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/TankData")]
public class TankData : ScriptableObject
{
    [SerializeField]
    float tankSpeed = 0.25f;

    [SerializeField]
    private float currentTankSpeed = 0.001f;

    [SerializeField]
    private float leftRightMovementMultiplier = 0.1f;

    //====================================================//

    public float TankSpeed { get { return tankSpeed; } }

    public float CurrentTankSpeed { get { return currentTankSpeed; } }

    public float LeftRightMovementMultiplier { get { return leftRightMovementMultiplier; } }

    //====================================================//

    public void ChangeTankSpeed(float newSpeed , Object caller)
    {
        if (caller.GetType() != typeof(TankEngine)) return;
        currentTankSpeed = newSpeed;
    }
}
