using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class WordHelper
{

    const int BigCharsStartASCII = 65;
    static float letterPadding = StaticData.KeysData.WordLetterPadding;

    #region Initializing Chars Letters as Objects

    public static string InitCharsWord(GameObject wordObj, string word)
    {
        int wordLenght = UnityEngine.Random.Range(1, 9);
        int dictLength = StaticData.KeysData.CharToGameObj.Count;

        for (int i = 0; i < wordLenght; i++)
        {
            char letter = word[i];

            GameObject letterObj = StaticData.KeysData.CharToGameObj[letter];
            GameObject spawnedLetter = GameObject.Instantiate(letterObj, wordObj.transform);
            spawnedLetter.transform.position += new Vector3(0f, 0f, i * letterPadding);
        }
        return word;
    }

    public static string InitRandomCharsWord(GameObject parent)
    {
        string word = "";
        int wordLenght = UnityEngine.Random.Range(1, 9);
        int dictLength = StaticData.WordData.CharToGameObj.Count;

        for (int i = 0; i < wordLenght; i++)
        {
            int charID = UnityEngine.Random.Range(0, dictLength);
            char letter = (char)(charID + BigCharsStartASCII);
            word += letter;

            GameObject letterObj = StaticData.WordData.CharToGameObj[letter];
            GameObject spawnedLetter = GameObject.Instantiate(letterObj, parent.transform);
            spawnedLetter.transform.position += new Vector3(0f, 0f, i * letterPadding);
        }

        return word;
    }

    #endregion

    public static void ChainWords(Word previous, Word current)
    {
        
    }

    public static float CalculateNextWordSpawn(Word word)
    {
        float time = word.WordLength
            * StaticData.TankData.CurrentTankSpeed
            * StaticData.WordData.WordSpawnIntervalMultiplier
            /* 0.5f*/;
        return time;
    }

    public static bool DisableWordLetter()
    {
        bool result = false;    

        return result;
    }

}
