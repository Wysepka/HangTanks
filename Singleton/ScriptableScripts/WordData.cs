using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/WordData")]
public class WordData : ScriptableObject
{
    //=====================================================//
    //----------------------- Data ------------------------//

    [SerializeField, Range(1f, 5f)]
    float wordLetterPadding = 1.5f;

    [SerializeField, Range(10f, 100f)]
    float wordSpawnIntervalMultiplier = 20f;

    //-----------------------------------------------------//

    [SerializeField]
    private WordSpawningType spawningType = WordSpawningType.RandomLetters;

    //-----------------------------------------------------//

    [SerializeField]
    private Material correctLetterMat=null, wrongLetterMat=null, currentLetterMat=null;

    //=====================================================//
    //-------------------- Dictionaries -------------------//

    [SerializeField]
    string[] wordsArrayTest;

    [SerializeField]
    CharToGameObject letterToObjDict = new CharToGameObject();


    //=====================================================//
    //--------------------- Accesors ----------------------//

    public float WordLetterPadding { get { return wordLetterPadding; } }
    public float WordSpawnIntervalMultiplier { get { return wordSpawnIntervalMultiplier; } }

    //-----------------------------------------------------//

    public WordSpawningType SpawningType { get { return spawningType; } }

    //-----------------------------------------------------//

    public Material CorrectLetterMat { get { return correctLetterMat; } }
    public Material WrongLetterMat { get { return wrongLetterMat; } }
    public Material CurrentLetterMat { get { return currentLetterMat; } }

    //-----------------------------------------------------//

    public string[] WordsArrayTest { get { return wordsArrayTest; } }

    //-----------------------------------------------------//

    public CharToGameObject CharToGameObj { get { return letterToObjDict; } }

    //=====================================================//
}
