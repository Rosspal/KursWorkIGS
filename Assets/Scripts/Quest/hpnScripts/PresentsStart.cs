using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PresentsStart : stateOfQuests
{
    [SerializeField] GameObject _presentQuest;
    [SerializeField] GameObject _ui;

    public override void Go()
    {
        _presentQuest.SetActive(true);
        _ui.SetActive(true);
    }

    public override void Start()
    {
        _presentQuest.SetActive(false);
        _ui.SetActive(false);
    }
}
