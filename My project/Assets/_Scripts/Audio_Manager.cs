using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Manager : MonoBehaviour
{

    public static Audio_Manager instance;

    public AudioSource bgAudioSource;
    public AudioSource sfxAudioSource;

    public AudioClip jump;

    public AudioClip coin;

    public Slider bgMusicVolSlidder;

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
    }

    // Start is called before the first frame update
    void Start()
    {
        bgMusicVolSlidder.value = bgAudioSource.volume;
        
    }

    public void PlayJump()
    {
        PlaySound(jump);
    }

    public void PlayCoin()
    {
        PlaySound(coin);
    }

    private void PlaySound(AudioClip clip)
    {
        sfxAudioSource.PlayOneShot(clip);
    }

    public void ChangeVolume()
    {
          bgAudioSource.volume = bgMusicVolSlidder.value;
    }
}
