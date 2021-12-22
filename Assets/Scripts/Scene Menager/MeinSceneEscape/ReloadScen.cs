using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScen : MonoBehaviour
{
    TimeRule _timeRule;
    private void Start()
    {
        _timeRule = GetComponent<TimeRule>();
    }
    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        _timeRule.Resume();
    }
}
