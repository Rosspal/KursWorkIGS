using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    [SerializeField] GameObject _pause;
    TimeRule _timeRule;
    bool onEscape = false;

    private void Start()
    {
        _pause.SetActive(false);
        _timeRule = GetComponent<TimeRule>();
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (onEscape == false)
            {
                _pause.SetActive(true);
                _timeRule.Pause();
                onEscape = !onEscape;
            }
            else
            {
                _pause.SetActive(false);
                _timeRule.Resume();
                onEscape = !onEscape;
            }
        }
    }
}
