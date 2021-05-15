using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyV1 : Key
{
    protected int correctChars = 0;

    protected int currentChar=0;
    protected string word="";
    protected int wordLength=0;
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();

        InitializeWordParameters();
        InitializeWordObjects();
    }

    //---------------------------------------------------------//

    private void OnEnable()
    {
        InputEventHandler.RegisterToKeyboardCharPressed(CheckKeyboardInput);   
    }

    private void OnDisable()
    {
        InputEventHandler.UnRegisterToKeyboardCharPressed(CheckKeyboardInput);
    }

    //--------------------------------------------------------//

    protected void InitializeWordParameters()
    {
        word = StaticData.KeysData.PredefinedWords.Random();
        wordLength = word.Length;
    }

    protected void InitializeWordObjects()
    {
        transform.GetChild(0).GetComponent<Text>().text = word[0].ToString();
        for (int i = 1; i < wordLength; i++)
        {
            GameObject wordObj = Instantiate(transform.GetChild(0).gameObject, transform);
            wordObj.GetComponent<Text>().text = word[i].ToString();
        }
    }

    //---------------------------------------------------------//

    void CheckKeyboardInput(char button)
    {
        if (word[currentChar] == button)
        {
            transform.GetChild(currentChar).GetComponent<Text>().color = Color.green;
            correctChars++;
        }
        else
        {
            transform.GetChild(currentChar).GetComponent<Text>().color = Color.red;
        }
        currentChar++;

        if (currentChar >= wordLength)
        {
            eventHandler.InvokeKeywordTyped(new KeyResultV1(correctChars, wordLength));
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0f,-StaticData.KeysData.KeyObjSpeed,0f); 
    }
}
