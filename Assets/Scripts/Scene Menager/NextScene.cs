using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] int index;

    public void nextScene()
    {
        SceneManager.LoadScene(index);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
