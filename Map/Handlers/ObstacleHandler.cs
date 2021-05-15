using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MEC;

public class ObstacleHandler : MonoBehaviour
{
    [SerializeField]
    List<GameObject> obstaclePrefabs;
    [SerializeField]
    Transform obstaclesParent;

    private Vector2 obstacleCooldownRange = new Vector2(2f, 4f);
    private List<Obstacle> obstaclesSpawned = new List<Obstacle>();

    protected void Awake()
    {
        InitializeProperties();
    }

    protected virtual void InitializeProperties()
    {
        obstaclePrefabs = StaticData.ObstacleData.ObstaclesPrefabs;
        obstacleCooldownRange = StaticData.ObstacleData.ObstacleSpawnCooldownRange;
    }

    // Start is called before the first frame update
    protected void Start()
    {
        Timing.RunCoroutine(SpawnObstacleWave(), Segment.SlowUpdate, "ObstacleSpawner");
    }

    protected virtual IEnumerator<float> SpawnObstacleWave()
    {
        while (gameObject.activeInHierarchy)
        {
            float cooldown = UnityEngine.Random.Range(obstacleCooldownRange.x, obstacleCooldownRange.y);
            yield return Timing.WaitForSeconds(cooldown);

            int obstacleIndex = UnityEngine.Random.Range(0, obstaclePrefabs.Count);
            GameObject obstacleSpawned = Instantiate(obstaclePrefabs[obstacleIndex], obstaclesParent);
            //obstaclesSpawned.Add(obstacleSpawned.GetComponent<Obstacle>());
        }

    }
    
}
