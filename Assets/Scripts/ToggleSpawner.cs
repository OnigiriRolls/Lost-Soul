using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSpawner : MonoBehaviour
{
    public GameObject spawner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            bool state = spawner.activeInHierarchy;
            spawner.SetActive(!state);
        }
    }
}
