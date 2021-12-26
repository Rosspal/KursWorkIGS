using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    [SerializeField] int level;
    public void loadScene()
    {
        SceneManager.LoadScene(level);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void loadMainScene()
    {
        SceneManager.LoadScene(0);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
