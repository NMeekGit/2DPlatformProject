using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject heartPrefab;
    public List<GameObject> heartList;
    public int numberOfHearts = 3;
    public float heartSpacingX = 1f;
	Arena arena;

	void Start()
	{
		arena = Camera.main.GetComponent<Arena>();
	}

    // Start is called before the first frame update
    public void instantiateHearts()
    {
        heartList = new List<GameObject>();

        for (int i = 0; i < numberOfHearts; i++)
        {
            GameObject tHeartGO = Instantiate(heartPrefab) as GameObject;
            tHeartGO.transform.parent = gameObject.transform;
            Vector2 pos = new Vector2(transform.position.x, transform.position.y);
            pos.x += (heartSpacingX * i);
            tHeartGO.transform.position = pos;
            heartList.Add(tHeartGO);
        }
    }

	public void removeHeart()
	{
		if (heartList == null) {
			arena.GameOver();
		}
		else {
			int heartIndex = heartList.Count - 1;
			GameObject tHeartGO = heartList[ heartIndex ];
			heartList.RemoveAt( heartIndex );
			Destroy( tHeartGO );
		}
	}
}
