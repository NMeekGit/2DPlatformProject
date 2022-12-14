using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject infectedPrefab;
	public GameObject heartOB;
    public GameObject player;
    GameObject spawnMain;
    GameObject spawnInfected;
    public Arena arScript;
	public Hearts hearts;
    
    // Start is called before the first frame update
    void Start()
    {
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
            arScript.PlayerInfected();
            GameObject infectedPlayer = Instantiate(infectedPrefab, spawnInfected.transform.position, spawnInfected.transform.rotation) as GameObject;
            player.transform.position = spawnMain.transform.position;
			hearts.removeHeart();
        }

        if (collidedWith.tag == "Boundary")
        {
            Debug.Log("Boundary Collision");
        }

		if (collidedWith.tag == "Projectile")
		{
			Debug.Log("shot detected");
			hearts.removeHeart();
            player.transform.position = spawnMain.transform.position;
		}
    }      
        
    void OnTriggerEnter2D( Collider2D trig )
    {
        Debug.Log("Trigger");
        GameObject collidedWith = trig.gameObject;
    }
}
