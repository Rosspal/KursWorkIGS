using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    [SerializeField] GameObject ScoreText;
    private int point = 0;

    public void Addcount(int money)
    {
        point+=money;
        ScoreText.GetComponent<Text>().text = "Money: " + point.ToString();    
    }
}
