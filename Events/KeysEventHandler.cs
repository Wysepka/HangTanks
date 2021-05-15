using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysEventHandler
{
    static System.Action<GameObject> keywordTypedGameObject;
    static System.Action<KeyResultV1> keywordTyped;

    public KeysEventHandler()
    {

    }

    //------------------------------------------------------------------------//

    public void InvokeKeywordTyped(GameObject caller)
    {
        if (keywordTypedGameObject != null) { keywordTypedGameObject.Invoke(caller); }
    }

    public void InvokeKeywordTyped(KeyResultV1 keyResult)
    {
        if (keywordTypedGameObject != null) { keywordTyped.Invoke(keyResult); }
    }

    //------------------------------------------------------------------------//

    public static void RegisterToKeywordTyped(System.Action<GameObject> action)
    {
        keywordTypedGameObject += action;
    }

    public static void RegisterToKeywordTyped(System.Action<KeyResultV1> action)
    {
        keywordTyped += action;
    }
    
    //------------------------------------------------------------------------//

    public static void UnRegisterToKeywordTyped(System.Action<GameObject> action)
    {
        keywordTypedGameObject -= action;
    }

    public static void UnRegisterToKeywordTyped(System.Action<KeyResultV1> action)
    {
        keywordTyped -= action;
    }

    //------------------------------------------------------------------------//

}
