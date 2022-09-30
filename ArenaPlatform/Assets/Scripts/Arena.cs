using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject player;

    GameObject spawn1;
    GameObject spawn2;
    GameObject spawn3;
    GameObject spawn4;
    public GameObject heart;

    public float totalZombies;
    public float timeToSpawn;
    
    float numZombies;
	bool dead;
	bool stopSpawn;

    Hearts createHearts;

    // Start is called before the first frame update
    void Start()
    {
		dead = false;
        InvokeRepeating("SpawnEnemy", 3, timeToSpawn);

        spawn1 = GameObject.Find("Spawn1");
        spawn2 = GameObject.Find("Spawn2");
        spawn3 = GameObject.Find("Spawn3");
        spawn4 = GameObject.Find("Spawn4");
        
        numZombies = 0f;

        createHearts = heart.GetComponent<Hearts>();
        createHearts.instantiateHearts();
    }

    // Update is called once per frame
    void Update()
    {
        if (dead) 
		{
			stopSpawn = true;
		}
    }

    void SpawnEnemy()
    {
		if (!stopSpawn) {
		
			float spawnPoint = Random.value;
			
			if (numZombies < totalZombies)
			{

				if (spawnPoint < 0.2f)
				{
					GameObject enemy = Instantiate(enemyPrefab) as GameObject;
					Rigidbody2D enemyPoint = enemy.GetComponent<Rigidbody2D>();
					enemyPoint.position = spawn1.transform.position;
				}
				else if (spawnPoint < 0.5f)
				{
					GameObject enemy = Instantiate(enemyPrefab) as GameObject;
					Rigidbody2D enemyPoint = enemy.GetComponent<Rigidbody2D>();
					enemyPoint.position = spawn2.transform.position;
				}
				else if (spawnPoint < 0.7f)
				{
					GameObject enemy = Instantiate(enemyPrefab) as GameObject;
					Rigidbody2D enemyPoint = enemy.GetComponent<Rigidbody2D>();
					enemyPoint.position = spawn3.transform.position;
				}
				else if (spawnPoint <= 1.0f)
				{
					GameObject enemy = Instantiate(enemyPrefab) as GameObject;
					Rigidbody2D enemyPoint = enemy.GetComponent<Rigidbody2D>();
					enemyPoint.position = spawn4.transform.position;
				}
				else
				{
					GameObject enemy = Instantiate(enemyPrefab) as GameObject;
					Rigidbody2D enemyPoint = enemy.GetComponent<Rigidbody2D>();
					enemyPoint.position = spawn1.transform.position;
				}
			}
		}
    }

	public void GameOver()
	{
		Destroy( player );
	}
    
    public void PlayerInfected()
    {
       GameObject[] zombieArray = GameObject.FindGameObjectsWithTag("Enemy");
       foreach (GameObject zombieGO in zombieArray)
       {
           Destroy(zombieGO);
       } 
    }
    
    public float GetNum()
    {
        return numZombies;
    }
    
    public void AddNum()
    {
        numZombies += 1;
    }
    
    public string Score()
    {
        return numZombies.ToString() + "/" + totalZombies.ToString();
    }

}
