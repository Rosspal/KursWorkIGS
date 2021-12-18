using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class respawnMoney : MonoBehaviour
{
    public GameObject money;
    private GameObject newMoney;
    private float time;
    private Vector3 Pos;
    private bool check = false;



    public void respawn(Vector3 pos)
    {
        Pos = pos;
        time = 3;
        check = true;
    }

    void Update()
    {
        if (check)
        {
            time = time - Time.deltaTime;
            if ((time > 0) && (time < 1))
            {
                newMoney = Instantiate(money, Pos, Quaternion.identity);
                newMoney.SetActive(true);
                check = false;
            }
        }
    }
}