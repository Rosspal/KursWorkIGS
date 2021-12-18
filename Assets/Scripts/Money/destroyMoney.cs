using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class destroyMoney : MonoBehaviour
{
    public scoring _scoring;


    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Money")
        {
            _scoring.Addcount(collider.gameObject.GetComponent<memoryMoneyCoast>().PointCount);
            Destroy(collider.gameObject);
        }
    }
}