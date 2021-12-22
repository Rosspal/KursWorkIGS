using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolume : MonoBehaviour
{
    private float volume = 0.5f;
    [SerializeField] AudioSource fond;
    [SerializeField] AudioSource money;
    [SerializeField] AudioSource damage;
    private float result;

    void Start()
    {

    }

    void Update()
    {
        result = ((float)PlayerPreferens.volume / 100) * 90;
        fond.volume = PlayerPreferens.volume + result;
        money.volume = PlayerPreferens.volume;
        damage.volume = PlayerPreferens.volume;
    }
}
