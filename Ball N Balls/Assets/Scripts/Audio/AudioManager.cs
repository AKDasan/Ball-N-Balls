using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    private AudioSource audioSource;


    [SerializeField] private AudioClip collectClip;
    [SerializeField] private AudioClip jumpPadClip;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();

        HealthBall.OnHBallCollected += PlayCollectSound;
        JumpPad.OnBallCollision += PlayJumpPadSound;
    }

    void PlayCollectSound()
    {
        audioSource.PlayOneShot(collectClip);
    }

    void PlayJumpPadSound()
    {
        audioSource.PlayOneShot(jumpPadClip);
    }

    private void OnDestroy()
    {
        HealthBall.OnHBallCollected -= PlayCollectSound;
        JumpPad.OnBallCollision -= PlayJumpPadSound;
    }
}
