using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoligonInfo : MonoBehaviour
{
    [SerializeField] GameObject Coin1;
    [SerializeField] GameObject Coin2;
    [SerializeField] GameObject Coin3;
    [SerializeField] int level;
    private void Start()
    {
        Coin1.SetActive(false);
        Coin2.SetActive(false);
        Coin3.SetActive(false);

        PlayerPreferens.LevelInfo it = (PlayerPreferens.LevelInfo)PlayerPreferens.list[level];

        if(it.money==3)
        {
            Coin1.SetActive(true);
            Coin2.SetActive(true);
            Coin3.SetActive(true);
        }
        if(it.money==2)
        {
            Coin1.SetActive(true);
            Coin2.SetActive(true);
            Coin3.SetActive(false);
        }
        if(it.money==1)
        {
            Coin1.SetActive(true);
            Coin2.SetActive(false);
            Coin3.SetActive(false);
        }
        if(it.money==0)
        {
            Coin1.SetActive(false);
            Coin2.SetActive(false);
            Coin3.SetActive(false);
        }
    }
}
