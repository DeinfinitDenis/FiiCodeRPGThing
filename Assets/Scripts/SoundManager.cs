using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum song 
{
    mainTheme, forestTheme
}



public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance { get; private set; }

    private AudioSource musicSource;

    public List<AudioClip> musicClips;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else 
        {
            Instance = this;
        }
        musicSource = GetComponent<AudioSource>();
    }

    public void PlaySong(song s) 
    {
        switch (s) 
        {
            case song.mainTheme:
                musicSource.Stop();
                musicSource.clip = musicClips[0];
                musicSource.Play();
                break;
            case song.forestTheme:
                musicSource.Stop();
                musicSource.clip = musicClips[1];
                musicSource.Play();
                break;

        
        }
    
    }

}
