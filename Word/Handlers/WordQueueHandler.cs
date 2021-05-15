using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordQueueHandler
{
    protected List<Word> wordsSpawnedQueue = new List<Word>();


    public WordQueueHandler()
    {
        WordEventHandler.RegisterToKeywordTyped(WordTyped);
    }

    public virtual void AddWordToQueue(Word word)
    {
        if(wordsSpawnedQueue.Count == 0)
        {
            word.InitializeWordTyping();
        }

        wordsSpawnedQueue.Add(word);
        CheckQueueStatus();
    }

    protected virtual void CheckQueueStatus()
    {

    }

    protected virtual void WordTyped(Word word)
    {
        word.DeInitializeWordTyping();
        wordsSpawnedQueue.Remove(word);

        if (wordsSpawnedQueue.Count >= 1) wordsSpawnedQueue[0].InitializeWordTyping();

        CheckQueueStatus();
    }
}
