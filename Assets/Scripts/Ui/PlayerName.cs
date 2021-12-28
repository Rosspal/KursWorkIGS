using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour
{
    private string _name;
    // Start is called before the first frame update
    void Start()
    {
        _name = PlayerPreferens.name;
        GetComponent<Text>().text = _name;
    }
}
