using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MEC;
using System.Linq;
using UnityEngine.Events;

public class WordSpawner : MonoBehaviour
{
    //=========================================================================//

    protected WordQueueHandler queueHandler = new WordQueueHandler();

    [SerializeField]
    protected GameObject wordPrefab;

    [SerializeField]
    protected Transform wordsParent;

    [SerializeField]
    protected Transform wordStartPos;

    [SerializeField]
    protected Transform wordEndPos;

    //------------------------------------------------------------------------//

    protected UnityAction<Word> newWordSpawned;

    //------------------------------------------------------------------------//

    [SerializeField]
    protected WordSpawnerState spawnerState = WordSpawnerState.Spawning;

    //------------------------------------------------------------------------//

    float wordSpawnInterval = 3f;

    //------------------------------------------------------------------------//

    [SerializeField]
    protected Word previousWordSpawned;

    [SerializeField]
    protected Queue<Word> wordsSpawned = new Queue<Word>();

    //------------------------------------------------------------------------//

    // Start is called before the first frame update
    protected void Start()
    {
        Timing.RunCoroutine(SpawnWordsRepeating(wordSpawnInterval));
    }

    protected virtual void RunWordsSpawner()
    {
        switch (StaticData.WordData.SpawningType)
        {
            case WordSpawningType.RandomLetters:
                Timing.RunCoroutine(SpawnWordsRepeating(wordSpawnInterval));
                break;
            case WordSpawningType.RandomWords:
                Timing.RunCoroutine(SpawnWordsRepeating(wordSpawnInterval));
                break;
            case WordSpawningType.StringArray:
                Timing.RunCoroutine(SpawnWordsInArraySequence(StaticData.WordData.WordsArrayTest));
                break;
            default:
                break;
        }
    }

    //====================================================================//

    private void OnEnable()
    {
        WordEventHandler.RegisterToKeywordTyped(SpawnedWordTyped);
    }

    private void OnDisable()
    {
        WordEventHandler.UnRegisterToWordTyped(SpawnedWordTyped);
    }

    //====================================================================//

    protected virtual IEnumerator<float> SpawnWordsRepeating(float delay)
    {
        float timer = 0f;

        while (true)
        {

            if (spawnerState == WordSpawnerState.Spawning && wordSpawnInterval < timer)
            {
                SpawnWord();
                timer = 0f;
                //yield return Timing.WaitForSeconds(delay);
            }

            timer += Timing.DeltaTime;
            yield return Timing.DeltaTime;
        }
    }

    protected virtual IEnumerator<float> SpawnWordsInArraySequence(string[] words)
    {
        int currentWord = 0;
        int wordsCount = words.Length;
        float timer = 0f;

        while(currentWord < wordsCount)
        {
            if(spawnerState == WordSpawnerState.Spawning && wordSpawnInterval < timer)
            {
                SpawnWord();
                timer = 0f;
                currentWord++;
                //yield return Timing.WaitForSeconds(wordSpawnInterval);
            }

            timer += Timing.DeltaTime;
            yield return Timing.DeltaTime;
        }

    }

    //====================================================================//

    protected virtual void SpawnWord()
    {
        if(wordPrefab != null)
        {
            GameObject spawnedWord = Instantiate(wordPrefab, wordsParent);
            InitializeWordParams(spawnedWord);
        }
    }

    protected virtual void InitializeWordParams(GameObject wordObj)
    {
        Word wordSpawned = wordObj.GetComponent<Word>();
        switch (StaticData.WordData.SpawningType)
        {
            case WordSpawningType.RandomLetters:
                wordSpawned.InitializeWordSetup(wordStartPos.position, wordEndPos.position);
                break;
            case WordSpawningType.RandomWords:
                wordSpawned.InitializeWordSetup(wordStartPos.position, wordEndPos.position);
                break;
            case WordSpawningType.StringArray:
                wordSpawned.InitializeWordSetup(wordStartPos.position, wordEndPos.position);
                break;
            default:
                break;
        }

        wordSpawnInterval = WordHelper.CalculateNextWordSpawn(wordSpawned);
        //Debug.Log("Interval: " + wordSpawnInterval);
        queueHandler.AddWordToQueue(wordSpawned);

    }

    //====================================================================//

    void SpawnedWordTyped(Word wordTyped)
    {
        /*
        if (wordsSpawned == null || wordsSpawned.Count == 0) return;

        //wordsSpawned.All<Word>(x => x.WordID == wordTyped.WordID);
        wordsSpawned.Dequeue();
        wordsSpawned.Peek().InitializeWordTyping();
        */
    }

}
