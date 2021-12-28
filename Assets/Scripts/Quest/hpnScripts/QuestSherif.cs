using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSherif : stateOfQuests
{
    [SerializeField] GameObject _triggerActive;
    [SerializeField] GameObject _nowTrigger;

    public override void Go()
    {
        _nowTrigger.SetActive(false);
        _triggerActive.SetActive(true);
    }

    public override void Start()
    {
        _triggerActive.SetActive(false);
    }

}
