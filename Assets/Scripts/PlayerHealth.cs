using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerHealth : MonoBehaviour
{
    public GameObject gameOverObject;
    public GameObject[] lives;
    GameOver gameOver;
    int life;

    void Start()
    {
        gameOver = gameOverObject.GetComponent("GameOver") as GameOver;
        Debug.Log(gameOver);
        life = 3;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("in trigger");
        if (collision.CompareTag("Enemy"))
        {
            life--;
            Debug.Log(lives.Length);
            if (life >= 0)
                lives[life].SetActive(false);

            if (life == 0)
            {
                Debug.Log("in if");
                gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
                gameOver.SetGameOver();
            }
        }

    }

}
