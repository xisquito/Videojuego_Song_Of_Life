using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MusicSlider : MonoBehaviour
{
    public Slider sliderMusic;


    public void LoadSliderScene()
    {
        if (sliderMusic != null)
        {
            sliderMusic.value = MusicPlayer.sharedInstance.MusicVolume;
        }
    }

    public void SetMusicVolume()
    {
        MusicPlayer.sharedInstance.SetVolume(sliderMusic.value);
    }
}