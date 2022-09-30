using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public GameObject player;
    Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = player.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
