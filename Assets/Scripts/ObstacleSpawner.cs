using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float spawnTime;
    public GameObject obstacle;
    public Transform leftSpawnerTranform;
    public Transform rightSpawnerTranform;

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
            int randomIndex = Random.Range(0, 2);
            switch (randomIndex)
            {
                case 0:
                    GameObject a= Instantiate(obstacle, leftSpawnerTranform);
                    Destroy(a, 5);
                    break;
                case 1:
                    GameObject b = Instantiate(obstacle, rightSpawnerTranform);
                    Destroy(b, 5);
                    break;
            }
            yield return new WaitForSeconds(spawnTime);
        }
        
    }
}
