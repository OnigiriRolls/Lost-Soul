using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Canvas canvas;
    public RectTransform panel;
    public Button pauseButton;
    public Image pauseImg;

    void Start()
    {
        panel.gameObject.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        collision.gameObject.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezePosition;
        SetGameOver();
    }

    public void SetGameOver()
    {
        panel.gameObject.SetActive(true);
        pauseButton.gameObject.SetActive(false);
        pauseImg.gameObject.SetActive(false);
    }

}
