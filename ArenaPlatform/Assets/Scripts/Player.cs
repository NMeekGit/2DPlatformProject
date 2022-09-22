using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject infectedPrefab;
    public Transform pos;
    GameObject player;
    GameObject spawnMain;
    GameObject spawnInfected;
    
    // Start is called before the first frame update
    void Start()
    {
	player = GameObject.Find("Player");
	spawnMain = GameObject.Find("Respawn(main)");
	spawnInfected = GameObject.Find("Spawn1");
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnCollisionEnter2D( Collision2D coll )
    {
        Debug.Log("collision");
        GameObject collidedWith = coll.gameObject;
        if ( collidedWith.tag == "Enemy" )
        {
       	    Debug.Log("enemy collision");
            Destroy( collidedWith );
            GameObject infectedPlayer = Instantiate(infectedPrefab, spawnInfected.transform.position, spawnInfected.transform.rotation) as GameObject;
            player.transform.position = spawnMain.transform.position;
            //Arena(Infected());
        }
    }
}
