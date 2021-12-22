using System;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    private DateTime timeBegin;
    private TimeSpan timeTimer;
    public string timeString;
    public bool check = false;

    void Start()
    {
        timeBegin = DateTime.Now;
    }

    private void Update()
    {
        if (check)
        {
            timeTimer = DateTime.Now - timeBegin;
            timeString = string.Format("{0:D2}:{1:D2}:{2:D2}", timeTimer.Hours, timeTimer.Minutes, timeTimer.Seconds);
        }
    }


    public void refresh()
    {
        timeBegin = DateTime.Now;
    }

    public void start()
    {
        refresh();
        check = true;
    }

    public void stop()
    {
        check = false;
        refresh();
    }
}
