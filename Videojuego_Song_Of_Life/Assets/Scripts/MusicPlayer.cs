using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicPlayer : MonoBehaviour
{

    public static MusicPlayer sharedInstance;


    private AudioSource audioSrc;

    private float musicVolume = 0.3f;
    public float MusicVolume
    {
        get
        {
            return musicVolume;
        }
    }

   
    // Start is called before the first frame update
    void Start()
    {

        if (sharedInstance == null)
        {
            sharedInstance = this;
            DontDestroyOnLoad(gameObject);
            audioSrc = GetComponent<AudioSource>();
            SetVolume(PlayerPrefs.GetFloat("musicVolume", 1f));
        }
        else
        {
            Destroy(gameObject);
        }


        
    }


      public void SetVolume(float vol)
    {
        musicVolume = vol;
        audioSrc.volume = musicVolume;
        PlayerPrefs.SetFloat("musicVolume", audioSrc.volume);
    }
   
}
