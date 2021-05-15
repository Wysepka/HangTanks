using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WordFillBarUI : MonoBehaviour
{

    Image bar;

    // Start is called before the first frame update
    void Start()
    {
        bar = GetComponent<Image>();
    }

    private void OnEnable()
    {
        WordEventHandler.RegisterToWordUpdate(UpdateFilledBar);
    }

    private void OnDisable()
    {
        WordEventHandler.UnRegisterToWordUpdate(UpdateFilledBar);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateFilledBar(WordUpdate wordUpdate)
    {
        this.bar.fillAmount = wordUpdate.WordTypedProgress;
    }
}
