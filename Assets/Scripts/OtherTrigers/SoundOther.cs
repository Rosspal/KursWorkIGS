using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundOther : MonoBehaviour
{
    private bool check = true;
    [SerializeField] AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (check)
            {
                check = false;
                sound.Play();
            }
        }
    }
}
