using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;


    public AudioClip background;
    public AudioClip playerShooting;


    void Start()
    {
        musicSource.clip = background;
        musicSource.Play();
    }

    public void playerShootingSound(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
