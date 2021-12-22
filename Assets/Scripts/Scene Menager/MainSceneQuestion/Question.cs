using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question : MonoBehaviour
{
    [SerializeField] GameObject _question;
    TimeRule _timeRule;

    private void Start()
    {
        _question.SetActive(false);
        _timeRule = GetComponent<TimeRule>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Question")
        {
            _question.SetActive(true);
            _timeRule.Pause();
        }
    }
}
