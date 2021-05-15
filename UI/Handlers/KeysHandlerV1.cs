using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeysHandlerV1 : KeysHandler
{

    new void Start()
    {
        SpawnKey();
    }

    private void OnEnable()
    {
        KeysEventHandler.RegisterToKeywordTyped(KeyTyped);
    }

    private void OnDisable()
    {
        KeysEventHandler.UnRegisterToKeywordTyped(KeyTyped);
    }

    private void KeyTyped(KeyResultV1 keyResultV1)
    {
        SpawnKey();
    }

}
