using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public Animator transitionAnim;
    public string sceneName;
    public RectTransform panel;
    public RectTransform howToPanel;
    public RectTransform startPanel;
    public void OnClick()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        panel.gameObject.SetActive(true);
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(0.9f);
        SceneManager.LoadScene(sceneName);       
    }

    public void OnHowTo()
    {
        howToPanel.gameObject.SetActive(true);
        startPanel.gameObject.SetActive(false);
    }
}
