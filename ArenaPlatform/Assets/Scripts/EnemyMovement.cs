using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = .1f;
    public Rigidbody2D rb;
    Rigidbody2D rbPlayer;

    void Start()
    {
        GameObject player = GameObject.Find("Player");
        rbPlayer = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        rb.position = Vector2.MoveTowards(rb.position, rbPlayer.position, speed * Time.fixedDeltaTime);
        Vector2 lookDir = rb.position - rbPlayer.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
}
