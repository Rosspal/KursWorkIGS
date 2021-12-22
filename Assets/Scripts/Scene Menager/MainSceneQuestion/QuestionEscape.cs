using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionEscape : MonoBehaviour
{
   [SerializeField] GameObject _question;
    TimeRule _timeRule;

    private void Start()
    {
        _timeRule = GetComponent<TimeRule>();
    }


    public void Resume()
    {
        _question.SetActive(false);
        _timeRule.Resume();
    }
}
