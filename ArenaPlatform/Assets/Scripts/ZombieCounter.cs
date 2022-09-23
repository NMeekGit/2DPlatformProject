using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZombieCounter : MonoBehaviour
{
    public TextMeshProUGUI score;
    Arena counter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        counter = Camera.main.GetComponent<Arena>();
        score = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void FixedUpdate()
    {
       score.SetText(counter.Score());
    }
}
