using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Spotify : MonoBehaviour
{
    public AudioClip[] songs;
    public int currentSong;
    private AudioSource audioSource;
    public TextMeshProUGUI songName;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        currentSong = 0;
        UpdateSong();
    }

    public void PlaySong()
    {
        audioSource.clip = songs[currentSong];
        audioSource.Play();
        songName.text = songs[currentSong].name;
        UpdateSong();
    }
    public void NextSong()
    {
        currentSong++;
        if(currentSong >= songs.Length)
        {
            currentSong = 0;
        }
        UpdateSong();
        PlaySong();
        
    }
    public void previousSong()
    {
        currentSong--;
        if(currentSong < 0)
        {
            currentSong = 0;
        }
        UpdateSong();
        PlaySong();
    }
    public void RandomSong()
    {
        Random.Range(0, songs.Length);
    }
    public void UpdateSong()
    {
        songName.text = songs[currentSong].name;
    }
}
