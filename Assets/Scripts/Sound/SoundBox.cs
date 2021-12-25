using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundBox : MonoBehaviour
{
    [SerializeField] GameObject sound;
    private AudioSource[] srs;

    private void Start()
    {
        srs = sound.GetComponents<AudioSource>();
    }

    public void Play(int n)
    {
        srs[n].Play();
        Debug.Log("Play");
    }

    public void Volume(float v)
    {
        foreach (AudioSource s in srs)
        {
            s.volume = v;
        }
    }

}
