using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PogigonInfoTime : MonoBehaviour
{
    string _timeString;
    [SerializeField] GameObject _time;
    [SerializeField] int _level;

    private void Start()
    {
        PlayerPreferens.LevelInfo it = (PlayerPreferens.LevelInfo)PlayerPreferens.list[_level];
        _time.GetComponent<Text>().text = _timeString = string.Format("{0:D2}:{1:D2}:{2:D2}", it.time.Hours, it.time.Minutes, it.time.Seconds);
    }
}
