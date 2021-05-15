using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeysHandler : MonoBehaviour
{
    [SerializeField]
    protected GameObject keyPrefab = null;

    protected GameObject activeKeyObj;
    protected Key activeKey;

    protected RectTransform rect;

    private void Awake()
    {
        if (rect == null) rect = GetComponent<RectTransform>();
    }

    // Start is called before the first frame update
    protected void Start()
    {

    }

    protected void SpawnKey()
    {
        if (keyPrefab != null)
        {
            activeKeyObj = Instantiate(keyPrefab, this.transform);
            SetKeyObjTransform();
            activeKey = activeKeyObj.GetComponent<Key>();
        }
    }

    protected virtual void SetKeyObjTransform()
    {

    }
}
