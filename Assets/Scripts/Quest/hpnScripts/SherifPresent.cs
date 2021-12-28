using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SherifPresent : stateOfQuests
{
    int countPresent = 0;
    [SerializeField] GameObject _countPresent;


    public override void Go()
    {
        countPresent = Convert.ToInt32(_countPresent.GetComponent<Text>().text);
        countPresent++;
        _countPresent.GetComponent<Text>().text = countPresent.ToString();
        countPresent = 0;
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

}
