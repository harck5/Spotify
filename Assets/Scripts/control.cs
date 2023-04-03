using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{
    public GameObject camera;
    private AudioSource _AudioSource;
    private void Start()
    {
        _AudioSource = camera.GetComponent<AudioSource>();
    }
    public void MusicVolume(float v)
        {
        _AudioSource.volume = v;
        }

}
