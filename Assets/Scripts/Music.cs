using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public Transform listenerTransform;
    public AudioSource audioSource;
    public float minDist = 0.1f;
    public float maxDist = 3;

    void FixedUpdate()
    {   
        if (listenerTransform)
        {
            float dist = getDist(transform, listenerTransform);
            //Debug.Log(dist);
            if (dist < minDist)
            {
                audioSource.volume = 1;
            }
            else
            {
                audioSource.volume = 1 - ((dist - minDist) / (maxDist - minDist));
            }
        }
    }

    private float getDist(Transform t1, Transform t2)
    {
        float dist1 = Vector3.Distance(t1.position, t2.position);
        float dist2 = Vector3.Distance(t2.position, t1.position);

        return dist1 > dist2 ? dist1 : dist2;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            listenerTransform = collision.transform;
            audioSource.Play(0);
            maxDist = Vector3.Distance(transform.position, listenerTransform.position);
            audioSource.volume = 0f;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (audioSource.volume > 0)
                fade();
        
            audioSource.volume = 0f;
            listenerTransform = null;
            audioSource.Stop();
        }
    }

    private void fade()
    {
        while (audioSource.volume > 0f)
        {
            if (audioSource.volume - 0.09f > 0f)
                audioSource.volume -= 0.09f;
            else return;
        }
    }
}
