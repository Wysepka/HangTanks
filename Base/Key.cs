using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Key : MonoBehaviour
{
    protected KeysEventHandler eventHandler;
    protected Text keyText;
    protected bool isActive;
    // Start is called before the first frame update
    protected void Start()
    {
        eventHandler = new KeysEventHandler();
        InitializeComponents();
    }

    protected virtual void InitializeComponents()
    {
        keyText = GetComponent<Text>();
    }

    public virtual void SetAsTypeable() { }

    public void EnableWordTyping() { isActive = true; }
}
