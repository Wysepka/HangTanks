using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Singleton/StaticData")]
public class StaticData : ScriptableObjectSingleton<StaticData>
{
    //=============================================================//

    [SerializeField]
    private KeysData keysData;

    [SerializeField]
    private MapData mapData;

    [SerializeField]
    private ObstacleData obstacleData;

    [SerializeField]
    private TankData tankData;

    [SerializeField]
    private WordData wordData;

    [SerializeField]
    private UtilityData utilityData;

    //=========================================================================//
    //--------------------------- Static Accesors -----------------------------//

    public static KeysData KeysData { get { return Instance.keysData; } }

    public static MapData MapData { get { return Instance.mapData; } }

    public static ObstacleData ObstacleData { get { return Instance.obstacleData; } }

    public static TankData TankData { get { return Instance.tankData; } }

    public static WordData WordData { get { return Instance.wordData; } }

    public static UtilityData UtilityData { get { return Instance.utilityData; } }

    //=========================================================================//
}
