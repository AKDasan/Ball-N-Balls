using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_Manager : MonoBehaviour
{
    public static Audio_Manager instance {  get; private set; }

    public AudioSource audioSource;
    public AudioClip coin_collect;
    public AudioClip h_ball_collect;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        audioSource = GetComponent<AudioSource>();
    }

    public void CoinCollectSound()
    {
        audioSource.PlayOneShot(coin_collect);
    }

    public void H_ballCollectSound()
    {
        audioSource.PlayOneShot(h_ball_collect);
    }
}
