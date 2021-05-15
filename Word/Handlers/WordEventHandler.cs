using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WordEventHandler
{

    static UnityAction<WordResult> wordTypedResult;
    static UnityAction<Word> wordTyped;
    static UnityAction<WordUpdate> wordUpdateEvent;

    public WordEventHandler()
    {

    }

    //------------------------------------------------------------------------//

    public void InvokeWordTyped(Word word, WordResult wordResult)
    {
        InvokeWordTyped(word);
        InvokeWordTypedResult(wordResult);
    }

    public void InvokeWordTypedResult(WordResult wordResult)
    {
        if (wordTypedResult != null) { wordTypedResult.Invoke(wordResult); }
    }

    public void InvokeWordTyped(Word word)
    {
        if(wordTyped != null) { wordTyped.Invoke(word); }
    }

    public void InvokeWordUpdate(WordUpdate wordUpdate)
    {
        if(wordUpdateEvent != null) { wordUpdateEvent.Invoke(wordUpdate); }
    }

    //------------------------------------------------------------------------//

    public static void RegisterToKeywordTypedResult(UnityAction<WordResult> action)
    {
        wordTypedResult += action;
    }

    public static void RegisterToKeywordTyped(UnityAction<Word> action)
    {
        wordTyped += action;
    }

    public static void RegisterToWordUpdate(UnityAction<WordUpdate> action)
    {
        wordUpdateEvent += action;
    }

    //------------------------------------------------------------------------//

    public static void UnRegisterToWordTypedResult(UnityAction<WordResult> action)
    {
        wordTypedResult -= action;
    }

    public static void UnRegisterToWordTyped(UnityAction<Word> action)
    {
        wordTyped -= action;
    }

    public static void UnRegisterToWordUpdate(UnityAction<WordUpdate> action)
    {
        wordUpdateEvent -= action;
    }

    //------------------------------------------------------------------------//


}
