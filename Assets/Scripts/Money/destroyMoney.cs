using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyMoney : MonoBehaviour
{
    public scoring _scoring;
    public statsHero statsHero;
    //public AudioSource audio;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Money")
        {
            //audio.Play(); //довать звук 
            statsHero.Scores(collider.gameObject.GetComponent<memoryMoneyCoast>().PointCount);
            _scoring.refresh();

            Destroy(collider.gameObject);
        }
    }
}
