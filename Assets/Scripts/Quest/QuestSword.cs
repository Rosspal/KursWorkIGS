using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestSword : stateOfQuests
{
    [SerializeField] GameObject sword;

    public override void Start()
    {
        sword.SetActive(false);
    }

    public override void Go()
    {
        sword.SetActive(true);
    }
}
