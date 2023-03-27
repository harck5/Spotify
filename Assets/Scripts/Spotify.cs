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
    public TextMeshProUGUI artist;
    public TextMeshProUGUI resetSong;
    //public Button playButton;
    //public Button pauseButton;

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
        artist.text = songs[currentSong].name;//De momento solo mete el mismo nombre de cancion creo que se huele con el array
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
    /*public void PlayButtonFuction()
    {
        playButton.interactable = false;
        pauseButton.interactable = true;
    }
    public void PauseButtonFuction()
    {
        playButton.interactable = true;
        pauseButton.interactable = false;
    }
    public void PlayPauseButtonFuntion(bool playButtonHasBeenPressed)
    {
        playButton.interactable = !playButtonHasBeenPressed;
        pauseButton.interactable = playButtonHasBeenPressed;
    }*/
}