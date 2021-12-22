using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneScoresCoin : MonoBehaviour
{
    [SerializeField] GameObject coin1;
    [SerializeField] GameObject coin2;
    [SerializeField] GameObject coin3;
    statsHero _statsHero;

    private void Start()
    {
        coin1.SetActive(false);
        coin2.SetActive(false);
        coin3.SetActive(false);
        _statsHero = GetComponent<statsHero>();
    }
    private void Update()
    {
        if (_statsHero.Scores() == 0)
        {
            coin1.SetActive(false);
            coin2.SetActive(false);
            coin3.SetActive(false);
        }
        if (_statsHero.Scores() == 1) 
            coin1.SetActive(true);
        if (_statsHero.Scores() == 2) 
            coin2.SetActive(true); 
        if (_statsHero.Scores() == 3) 
            coin3.SetActive(true); 
    }
}
