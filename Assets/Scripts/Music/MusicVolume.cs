using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    void Update()
    {
        this.GetComponent<SoundBox>().Volume(PlayerPreferens.volume);
    }
}
