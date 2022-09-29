using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hearts : MonoBehaviour
{
    public GameObject heartPrefab;
    public List<GameObject> heartList;
    public int numberOfHearts = 3;
    public float heartSpacingX = 1f;

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
}
