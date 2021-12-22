using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    private float volume = 0.5f;
    [SerializeField] AudioSource fond;
    [SerializeField] AudioSource money;

    void Start()
    {

    }

    void Update()
    {
        fond.volume = PlayerPreferens.volume;
        money.volume = PlayerPreferens.volume;
    }
}
