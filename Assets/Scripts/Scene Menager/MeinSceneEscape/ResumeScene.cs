using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeScene : MonoBehaviour
{
    public GameObject _pause;
    public TimeRule _timeRule;
    public GameObject _button;

    public void Resume()
    {
        _pause.SetActive(false);
        _timeRule.Resume();
    }
}
