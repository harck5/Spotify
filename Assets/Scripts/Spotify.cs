using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spotify : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentSong = 0;
        audioSource.clip = songs[currentSong];
    }

    public void PlaySong()
    {
        audioSource.clip = songs[currentSong];
        audioSource.Play();
    }
    public void NextSong()
    {
        currentSong++;
        if(currentSong >= songs.Length)
        {
            currentSong = 0;
        }
        PlaySong();
    }
    public void previousSong()
    {
        currentSong--;
        if(currentSong < 0)
        {
            currentSong = 0;
        }
        PlaySong();
    }
}
