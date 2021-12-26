using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimerLevelEnd : MonoBehaviour
{
    private DateTime timeBegin;
    public TimeSpan timeTimer;
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
            Debug.Log(timeTimer);
            if (timeTimer >= TimeSpan.Parse("00:00:04"))
            {
                SceneManager.LoadScene(8);
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                check = false;
            }
        }
    }

    public void start()
    {
        timeBegin = DateTime.Now;
        Debug.Log(TimeSpan.Parse("00:00:03"));
        check = true;
    }
}
