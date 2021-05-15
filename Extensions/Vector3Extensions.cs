using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vector3Extensions
{
    //Value in range (-1 to 1)
    public static Vector3 Lerp(this Vector3 vector , Vector3 from, Vector3 to, float value)
    {
        Vector3 midPos = Vector3.Lerp(from, to, 0.5f);
        if(value > 0f)
        {

            return Vector3.Lerp(midPos, to, value);
        }
        else
        {
            return Vector3.Lerp(from, midPos, 1f + value);
        }
    }
}
