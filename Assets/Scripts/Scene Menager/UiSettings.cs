using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiSettings : MonoBehaviour
{
    public GameObject LoseCanvas;
    public GameObject ScoreCanvas;
    public GameObject WinCanvas;

    private void Start()
    {
        LoseCanvas.SetActive(false);
        WinCanvas.SetActive(false);
        ScoreCanvas.SetActive(true);
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "DethZone")
        {
            LoseCanvas.SetActive(true);
            ScoreCanvas.SetActive(false);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        if (other.gameObject.tag == "Win")
        {
            WinCanvas.SetActive(true);
            ScoreCanvas.SetActive(false);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

}
