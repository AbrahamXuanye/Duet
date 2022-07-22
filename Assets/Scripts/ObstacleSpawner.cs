using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{

    public float spawnTime;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawner()
    {
        for (int i = 0; i < 100; i++)
        {
            GameObject.Instantiate(obstacle);
            yield return new WaitForSeconds(spawnTime);
        }
        
    }
}
