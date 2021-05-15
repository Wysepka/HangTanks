using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestReceiver : MonoBehaviour
{

    private void OnEnable()
    {
        KeysEventHandler.RegisterToKeywordTyped(DebugTestEvent);
    }

    private void OnDisable()
    {
        KeysEventHandler.UnRegisterToKeywordTyped(DebugTestEvent);
    }

    void DebugTestEvent(GameObject gameObject)
    {
        Debug.Log("Caller: " + gameObject.name + "| time: " + Time.time);
    }
}
