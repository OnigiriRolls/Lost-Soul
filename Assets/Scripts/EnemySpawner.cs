using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public float timer;
    public float delayTime;

    int enemiesSize;

    void Start()
    {
        enemiesSize = enemies.Length;
    }

    private void OnEnable()
    {
        StartCoroutine(Delay());
    }

    IEnumerator Spawn()
    {
        yield return new WaitForSeconds(timer);
        
        int randomIndex = Random.Range(0, enemiesSize);
        Instantiate(enemies[randomIndex], this.transform.position, Quaternion.identity);
        StartCoroutine("Spawn");
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(delayTime);
        StartCoroutine("Spawn");
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }

}
