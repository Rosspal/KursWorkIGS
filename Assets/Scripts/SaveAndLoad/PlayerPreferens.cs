using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

static class PlayerPreferens
{
    public struct LevelInfo
    {
        public TimeSpan time;
        public int money;
        public int level;
    }

    public static string name = "Name";
    public static float volume = 0.5f;
    public static LevelInfo level;
    public static ArrayList list = new ArrayList() {level, level, level, level, level, level, level };

    public static string PlayerToString()
    {
        string level = name + "|" + volume + "|";
        foreach (LevelInfo s in list)
        {
            if (s.level != 0)
            {
                level += s.level + "|" + s.money + "|" + s.time.ToString() + "|";
            }
        }
        level += "-1";
        return level ;
    }

    public static void refresh()
    {
        volume = 0.5f;
        for (int i = 0; i != 6; i++)
        {
            list[i] = level;
        }
    }
}
