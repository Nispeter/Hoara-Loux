using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusicController : MonoBehaviour
{
    [SerializeField] private AudioSource[] gameMusic;
    private int playListSize;

    private int currentSongIndex = 0;

    private void Start()
    {
        playListSize = gameMusic.Length ;
        PlayNextSong();
    }

    private void PlayNextSong()
    {
        gameMusic[currentSongIndex].Play();
        currentSongIndex = (currentSongIndex + 1) % gameMusic.Length;

    }

    private void Update()
    {   
        if(currentSongIndex >= playListSize )
            return;
        if (!gameMusic[currentSongIndex].isPlaying)
        {
            PlayNextSong();
        }
    }

}
