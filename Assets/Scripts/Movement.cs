using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody2D rb;
    public float absSpeed = 10f;
    public ParticleSystem ps;
    public float stickRadius;
    private bool facingLeft = false;
    private float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        absSpeed = Mathf.Abs(absSpeed);
        rb = GetComponent<Rigidbody2D>();
        ps.Emit(1);
        ps.Play();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal1 = 0;
        float vertical1 = 0;
                        
        horizontal1 = Input.GetAxis("Horizontal");
        vertical1 = Input.GetAxis("Vertical");

         Vector2 position = rb.position; 

        if (horizontal1 < (-1) * stickRadius)
        {
            //speed = (-1) * speed;

            if (facingLeft == false)
            {
                Flip();
            }
        }
        else if (horizontal1 > stickRadius)
        {
            speed = absSpeed;

            if (facingLeft == true)
            {
                Flip();
            }
        }

        position.x = position.x + 0.1f * horizontal1 * Time.deltaTime * speed;
        position.y = position.y + 0.1f * vertical1 * Time.deltaTime * absSpeed;

        rb.MovePosition(position);
    }

    void Flip()
    {
        facingLeft = !facingLeft;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}

