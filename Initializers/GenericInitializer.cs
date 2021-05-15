using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RotaryHeart.Lib.SerializableDictionary;

public class GenericInitializer
{

}

//[System.Serializable]
//public class CharToGameObject : SerializableDictionaryBase<char, GameObject> { }

#region KeyResult

public class KeyResult
{

}

public class KeyResultV1 : KeyResult
{
    protected int charsTypedCorrectly;
    protected int charsTotal;

    public KeyResultV1(int correct, int total)
    {
        charsTypedCorrectly = correct;
        charsTotal = total;
    }

    public int CharsTypedCorrectly { get { return charsTypedCorrectly; } }
    public int CharsTotal { get { return charsTotal; } }
}

#endregion

#region Word

public class WordResult
{
    string word;
    int correct;
    int total;

    public string Word { get { return word; } }
    public int Correct { get { return correct; } }
    public int Total { get { return total; } }

    public void IncreaseCorrect() { correct++; }

    public WordResult(string _word, int _correct, int _total)
    {
        this.word = _word;
        this.correct = _correct;
        this.total = _total;
    }
}

public struct WordUpdate
{
    // 0 - 1
    float wordTypedProgress;

    public float WordTypedProgress { get { return wordTypedProgress; } }

    public WordUpdate(float value)
    {
        this.wordTypedProgress = value;
    }

}

#endregion