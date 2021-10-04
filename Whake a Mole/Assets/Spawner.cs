using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject Beaver;
    [SerializeField] List<GameObject> holes;
    [SerializeField] float timePerSpawn = 1;
    float spawnTime;
    private void Update()
    {
        spawnTime += Time.deltaTime;
        if(Beaver && spawnTime > timePerSpawn)
        {
            Instantiate
                (Beaver, holes[Random.Range(0, holes.Count)].transform.position, Quaternion.identity);
            
            spawnTime = 0;
        }

    }
}
