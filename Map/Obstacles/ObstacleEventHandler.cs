using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ObstacleEventHandler
{
    static UnityAction obstaclePassed;

    public ObstacleEventHandler()
    {

    }

    public void InvokeObstaclePassed()
    {
        if(obstaclePassed != null)
        {
            obstaclePassed.Invoke();
        }
    }


    public static void RegisterToObstaclePassed(UnityAction action)
    {
        obstaclePassed += action;
    }

    public static void UnRegisterToObstaclePassed(UnityAction action)
    {
        obstaclePassed -= action;
    }
}
