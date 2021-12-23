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
            if (timeTimer >= TimeSpan.Parse("00:00:05"))
            {
                SceneManager.LoadScene(3);
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
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
