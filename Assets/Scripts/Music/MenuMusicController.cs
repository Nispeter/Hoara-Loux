using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusicController : MonoBehaviour
{
    [SerializeField] private AudioSource menuMusic;

    private void Start()
    {
        PlayNextSong();
    }

    private void PlayNextSong()
    {
        menuMusic.Play();
    }

    private void Update()
    {
        if (!menuMusic.isPlaying)
        {
            PlayNextSong();
        }
    }
}
