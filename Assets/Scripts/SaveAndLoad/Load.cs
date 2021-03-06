using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

public class Load : MonoBehaviour
{
    
    private string fileName;
    public static ArrayList list = new ArrayList();
    PlayerPreferens.LevelInfo info;

    public void loadingSave()
    {
        bool check = true;
        int i = 2;
        int level;
        fileName = PlayerPreferens.name + ".txt";

        if (!System.IO.File.Exists(fileName))
        {
            check = false;
        }

        PlayerPreferens.refresh();

        if (check)
        {
            using (StreamReader sw = new StreamReader(fileName))
            {
                while (!sw.EndOfStream)
                {
                    string str = sw.ReadLine();
                    String[] dataFromFile = str.Split(new String[] { "|" },
                        StringSplitOptions.RemoveEmptyEntries);

                    PlayerPreferens.name = dataFromFile[0];
                    PlayerPreferens.volume = (float)Convert.ToDouble(dataFromFile[1]);

                    while ((int)Convert.ToInt32(dataFromFile[i]) != -1)
                    {
                        info.level = level = (int)Convert.ToInt32(dataFromFile[i]);
                        i++;
                        info.money = (int)Convert.ToInt32(dataFromFile[i]);
                        i++;
                        info.time = TimeSpan.Parse(dataFromFile[i]);
                        i++;
                        PlayerPreferens.list[level] = info;
                    }
                }
            }
        }
    }
}
