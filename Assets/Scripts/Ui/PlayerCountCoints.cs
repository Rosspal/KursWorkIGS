using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCountCoints : MonoBehaviour
{
    private int _countCoins = 0;
    void Start()
    {
        for (int i = 1; i<=3;i++)
        {
            PlayerPreferens.LevelInfo it = (PlayerPreferens.LevelInfo)PlayerPreferens.list[i];
            _countCoins += it.money;
        }

        GetComponent<Text>().text = _countCoins.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
