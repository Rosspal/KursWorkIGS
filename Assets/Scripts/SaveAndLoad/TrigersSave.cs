using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class TrigersSave : MonoBehaviour
{
   [SerializeField] statsHero Hero;
    PlayerPreferens.LevelInfo info;//
   [SerializeField] LevelTimer time;//6
    public TimeSpan timer;

    public void SaveInfo()
    {
        info.level = SceneManager.GetActiveScene().buildIndex;
        PlayerPreferens.LevelInfo it = (PlayerPreferens.LevelInfo)PlayerPreferens.list[info.level];
        timer = TimeSpan.Zero;

        if (it.time == timer)
        {
            info.time = time.timeTimer;
        }
        else
        {
            if (time.timeTimer < it.time)
            {
                info.time = time.timeTimer;
            }
            else
            {
                info.time = it.time;
            }
        }

        if (Hero.Scores() > it.money)
        {
            info.money = Hero.Scores();
        }
        else
        {
            info.money = it.money;
        }

        PlayerPreferens.list[info.level] = info;
    }
}
