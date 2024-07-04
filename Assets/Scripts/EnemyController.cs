using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    Vector2 move;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        move.y = transform.position.y + 0.1f * (transform.position.y - 10f) * Time.deltaTime * speed;
        move.x = transform.position.x;
        rb.MovePosition(move);
    }
}
