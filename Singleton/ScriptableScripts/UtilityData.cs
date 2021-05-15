using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/UtilityData")]
public class UtilityData : ScriptableObject
{
    //=====================================================//
    //----------------------- Data ------------------------//

    [SerializeField, Range(0.1f, 10f)]
    float disableDelay = 1.5f;

    [SerializeField, Range(0.1f, 10f)]
    float destroyDelay = 1.5f;

    //-----------------------------------------------------//


    //=====================================================//
    //-------------------- Dictionaries -------------------//



    //=====================================================//
    //--------------------- Accesors ----------------------//

    public float DisableDelay { get { return disableDelay; } }

    public float DestroyDelay { get { return destroyDelay; } }

    //=====================================================//
}
