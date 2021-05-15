using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/KeysData")]
public class KeysData : ScriptableObject
{
    //=====================================================//
    //----------------------- Data ------------------------//

    [SerializeField]
    List<string> predefinedWords;

    [SerializeField, Range(0.1f, 1f)]
    float keyObjSpeed = 0.2f;

    [SerializeField , Range(1f , 5f)]
    float wordLetterPadding = 1.5f;



    //=====================================================//
    //-------------------- Dictionaries -------------------//

    [SerializeField]
    CharToGameObject letterToObjDict = new CharToGameObject();
    

    //=====================================================//
    //--------------------- Accesors ----------------------//

    public List<string> PredefinedWords { get { return predefinedWords; } }

    public float KeyObjSpeed { get { return keyObjSpeed; } }

    public float WordLetterPadding { get { return wordLetterPadding; } }

    //-----------------------------------------------------//

    public CharToGameObject CharToGameObj { get { return letterToObjDict; } }

    //=====================================================//
}
