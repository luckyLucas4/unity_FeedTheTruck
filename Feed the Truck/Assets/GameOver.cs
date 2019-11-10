using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<TruckMovement>())
        {
            StartCoroutine(GameOverFunction());
        }
    }

    private IEnumerator GameOverFunction()
    {
        audioSource.Play();
        yield return new WaitForSeconds(3);
    }
}
