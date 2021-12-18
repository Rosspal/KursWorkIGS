using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoring : MonoBehaviour
{
    [SerializeField] GameObject ScoreText;
    public statsHero statsHero;

    public void refresh()
    {
        ScoreText.GetComponent<Text>().text = "Money: " + statsHero.Scores();
    }
}