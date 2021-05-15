using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyV1_Chars : KeyV1
{

    // Start is called before the first frame update
    new void Start()
    {
        base.Start();

        InitializeWordObject();
    }

    protected void InitializeWordObject()
    {
        word = StaticData.KeysData.PredefinedWords.Random();
        wordLength = word.Length;
    }

}
