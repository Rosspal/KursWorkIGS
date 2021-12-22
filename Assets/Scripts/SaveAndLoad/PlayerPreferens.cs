using System.Collections;
using System.Collections.Generic;
using UnityEngine;

static class PlayerPreferens
{
    public struct LevelInfo
    {
        public string time;
        public int money;
        public int level;
    }

    public static string name = "Name";
    public static int volume = 0;
    public static ArrayList list = new ArrayList();
    //private int fullHD;

    public static string PlayerToString()
    {
        string level = "|";
        foreach (LevelInfo s in list)
        {
            level += s.level + "|" + s.money + "|" + s.time;
        }
        return name + "|" + volume + "|" + level ;
    }
}
