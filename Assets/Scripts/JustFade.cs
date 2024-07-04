using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustFade : MonoBehaviour
{
    public Animator transitionAnim;
    public RectTransform panel;
    void Start()
    {
        Debug.Log("hello");
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        panel.gameObject.SetActive(true);
        transitionAnim.SetTrigger("fadeOut");
        yield return new WaitForSeconds(1.5f);
        panel.gameObject.SetActive(false);
    }
}
