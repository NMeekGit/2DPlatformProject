using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject playerPrefab;

    GameObject spawn1;
    GameObject spawn2;
    GameObject spawn3;
    GameObject spawn4;
    Rigidbody2D point1;
    Rigidbody2D point2;
    Rigidbody2D point3;
    Rigidbody2D point4;

    public float timeToSpawn;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", 3, timeToSpawn);

        spawn1 = GameObject.Find("Spawn1");
        spawn2 = GameObject.Find("Spawn2");
        spawn3 = GameObject.Find("Spawn3");
        spawn3 = GameObject.Find("Spawn4");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        GameObject enemy = Instantiate(enemyPrefab) as GameObject;
        Rigidbody2D enemyPoint = enemy.GetComponent<Rigidbody2D>();
        float spawnPoint = Random.value;

        if (spawnPoint < .25f)
        {
            enemyPoint.position = spawn1.transform.position;
        }
        else if (spawnPoint < .5f)
        {
            enemyPoint.position = spawn2.transform.position;
        }
        else if (spawnPoint < .75f)
        {
            enemyPoint.position = spawn3.transform.position;
        }
        else if (spawnPoint <= 1.0f)
        {
            enemyPoint.position = spawn4.transform.position;
        }
    }
}
