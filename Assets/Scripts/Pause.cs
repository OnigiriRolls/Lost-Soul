using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public RectTransform panel;
    public Rigidbody2D player;
    public Button button;
    public Image img;

    public void OnPause()
    {
        panel.gameObject.SetActive(true);
        player.constraints = RigidbodyConstraints2D.FreezePosition;
        button.gameObject.SetActive(false);
        img.gameObject.SetActive(false);
    }

    public void OnRetry()
    {
        panel.gameObject.SetActive(false);
        player.constraints &= ~RigidbodyConstraints2D.FreezePosition;
        button.gameObject.SetActive(true);
        img.gameObject.SetActive(true);
    }

    public void OnExit()
    {
        SceneManager.LoadScene("Start");
    }

    public void Reload()
    {
        SceneManager.LoadScene("SampleScene");
    }

}
