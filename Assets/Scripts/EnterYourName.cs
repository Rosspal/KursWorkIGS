using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterYourName : MonoBehaviour
{
    [SerializeField] GameObject _playerName;

    public string GetPlayerName()
    {
        return _playerName.GetComponent<Text>().text;
    }

}
