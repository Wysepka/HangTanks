using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ListExtensions
{
    public static object Random(this List<object> list)
    {
        var random = list[UnityEngine.Random.Range(0, list.Count)];
        return random;
    }

    public static string Random(this List<string> list)
    {
        var random = list[UnityEngine.Random.Range(0, list.Count)];
        if (random != null) return random;
        else return list[0];
    }
    
}
