using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setValue : MonoBehaviour
{
    public Slider mainSlider;
    void Start()
    {
        mainSlider.value = PlayerPreferens.volume;
    }

    public void SetVolume(float vol)
    {
        PlayerPreferens.volume = vol;
    }
}
