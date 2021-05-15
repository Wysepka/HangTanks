using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEvents : MonoBehaviour
{
    KeysEventHandler eventHandler;

    // Start is called before the first frame update
    void Start()
    {
        eventHandler = new KeysEventHandler();
        InvokeRepeating("CallEventHandlerRepeated", 1f, Random.Range(2f, 4f));
    }

    void CallEventHandlerRepeated()
    {
        eventHandler.InvokeKeywordTyped(this.gameObject);
    }
}
