using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SaveName : MonoBehaviour
{
    public void SetName(string name)
    {
        PlayerPreferens.name = name;
        Debug.Log(PlayerPreferens.name);
    }
}
