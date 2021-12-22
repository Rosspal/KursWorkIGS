using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveName : MonoBehaviour
{
    public void SetName(string name)
    {
        PlayerPreferens.name = name;
    }
}
