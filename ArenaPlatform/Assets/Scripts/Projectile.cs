using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
	Arena hit;

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(gameObject);
        
        if(coll.gameObject.tag == ("Enemy"))
        {
            Destroy(coll.gameObject);
			hit = Camera.main.GetComponent<Arena>();
			hit.AddNum();
        }
    }
	
	void OnTriggerEnter2D(Collider2D coll)
	{
		Destroy(gameObject);
	}
}
