using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="Data/ObstacleData")]
public class ObstacleData : ScriptableObject
{
    //=====================================================//
    //----------------------- Data ------------------------//

    [SerializeField]
    Vector2 obstacleSpawnCooldownRange;

    [SerializeField]
    List<GameObject> obstaclesPrefabs;

    //=====================================================//
    //--------------------- Accesors ----------------------//

    public Vector2 ObstacleSpawnCooldownRange { get { return obstacleSpawnCooldownRange; } }

    public List<GameObject> ObstaclesPrefabs { get { return obstaclesPrefabs; } }

    //=====================================================//
}
