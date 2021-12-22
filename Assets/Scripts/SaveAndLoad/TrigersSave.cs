using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrigersSave : MonoBehaviour
{
   [SerializeField] statsHero Hero;
    PlayerPreferens.LevelInfo info;
   [SerializeField] LevelTimer time;

    public void SaveInfo()
    {
        info.money = Hero.Scores();
        info.time = time.timeString;
        info.level = SceneManager.GetActiveScene().buildIndex;
        PlayerPreferens.list.Add(info);
    }
}
