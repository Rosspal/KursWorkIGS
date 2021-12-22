using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyMoney : MonoBehaviour
{
    public scoring _scoring;
    public statsHero statsHero;
    public AudioSource audioMoney;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Money")
        {
            audioMoney.Play();
            statsHero.Scores(1);
            _scoring.refresh();
            Destroy(collider.gameObject);
        }
    }
}
