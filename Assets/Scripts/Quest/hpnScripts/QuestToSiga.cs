using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class QuestToSiga : stateOfQuests
{
    [SerializeField] GameObject _countPresent;


    public override void Go()
    {
        _countPresent.SetActive(true);
    }

    public override void Start()
    {
        _countPresent.SetActive(false);
    }
}

