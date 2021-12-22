using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;


public class TrigersSave : MonoBehaviour
{
   [SerializeField] statsHero Hero;
    PlayerPreferens.LevelInfo info;
   [SerializeField] LevelTimer time;
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
        }
        if (Hero.Scores() > it.money)
        {
            info.money = Hero.Scores();
        }
        
        PlayerPreferens.list.RemoveAt(info.level);
        PlayerPreferens.list.Insert(info.level, info);
    }
}
