using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using MEC;

public static class Utility
{

    public static IEnumerator<float> DelayDisableDestroy(this GameObject gameObject, float delayDis, float delayDes)
    {
        yield return Timing.WaitForSeconds(delayDis);

        gameObject.SetActive(false);

        yield return Timing.WaitForSeconds(delayDes);

        GameObject.Destroy(gameObject);
    }

}
