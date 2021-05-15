using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class WordV1 : Word
{
    // Start is called before the first frame update
    new void Start()
    {
        base.Start();
    }

    protected override void OnDisable()
    {
        base.OnDisable();
    }

    protected override void OnEnable()
    {
        base.OnEnable();
    }

    // Update is called once per frame
    new void Update()
    {
        base.Update();  
    }

    protected override void CheckKeyboardInput(char letter)
    {
        base.CheckKeyboardInput(letter);

        eventHandler.InvokeWordUpdate(new WordUpdate(this.currentChar / (float)this.wordLenght));
    }


}
