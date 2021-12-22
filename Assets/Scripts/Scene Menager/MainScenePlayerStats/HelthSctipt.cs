using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelthSctipt : MonoBehaviour
{
    [SerializeField] GameObject life1;
    [SerializeField] GameObject life2;
    [SerializeField] GameObject life3;
    [SerializeField] AudioSource _audioDamege;
    statsHero _statsHero;

    private void Start()
    {
        _statsHero = GetComponent<statsHero>();
        life1.SetActive(true);
        life2.SetActive(true);
        life3.SetActive(true);
    }

    private void Update()
    {
        if (_statsHero.getHp() == 3)
        {
            life1.SetActive(true);
            life2.SetActive(true);
            life3.SetActive(true);
        }
        if (_statsHero.getHp() == 2)
        {
            life3.SetActive(false);
        }
        if (_statsHero.getHp() == 1)
        {
            life2.SetActive(false);
        }
        if (_statsHero.getHp() == 0)
        {
            life1.SetActive(false);
        }

    }
}
