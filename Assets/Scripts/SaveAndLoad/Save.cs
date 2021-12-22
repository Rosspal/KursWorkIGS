using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Save : MonoBehaviour
{
    public void SaveToFile()
    {
        using (StreamWriter sw = new StreamWriter(PlayerPreferens.name + ".txt", false, System.Text.Encoding.Unicode))
        {
            sw.WriteLine(PlayerPreferens.PlayerToString());
        }
    }
}
