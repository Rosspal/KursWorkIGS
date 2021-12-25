using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyMoney : MonoBehaviour
{
    public statsHero statsHero;
    public AudioSource audioMoney;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Money")
        {
            audioMoney.Play();
            statsHero.Scores(1);
            Destroy(collider.gameObject);
        }
    }
}
