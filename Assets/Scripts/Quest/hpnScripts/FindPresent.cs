using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FindPresent : MonoBehaviour
{
    [SerializeField] GameObject _countPresents;
    private int count=0;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Present")
        {
            count = Convert.ToInt32(_countPresents.GetComponent<Text>().text);
            count++;
            _countPresents.GetComponent<Text>().text = Convert.ToString(count);
            count = 0;
            Destroy(other.gameObject);
        }
    }
}
