using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class respawnMoney : MonoBehaviour
{
    public struct taskSpawn
    {
        public float time;
        public Vector3 position;
        public int scores;
    }

    public GameObject money;
    //public GameObject bigMoney; // передавать объект, а не хранить тут
    private GameObject newMoney;
    private List<taskSpawn> listSpawn = new List<taskSpawn>();
    private taskSpawn tempMoneySpawn;
    private int i;



    public void respawn(Vector3 pos, int scores, float timeSpawn)
    {
        Debug.Log("вход в respawn   ");
        tempMoneySpawn.position = pos;
        tempMoneySpawn.scores = scores;
        tempMoneySpawn.time = timeSpawn;

        listSpawn.Add(tempMoneySpawn);
    }

    void Update()
    {

        if (listSpawn.Count > 0)
        {
            i = 0;
            while (i <= (listSpawn.Count - 1))
            {
                tempMoneySpawn = listSpawn[i];
                tempMoneySpawn.time = tempMoneySpawn.time - Time.deltaTime;
                listSpawn[i] = tempMoneySpawn;

                if ((listSpawn[i].time > 0) && (listSpawn[i].time < 1))
                {
                    switch (listSpawn[i].scores)
                    {
                        case 10:
                            newMoney = Instantiate(money, listSpawn[i].position, Quaternion.identity);
                            newMoney.SetActive(true);
                            break;
                        //case 50:
                        //    newMoney = Instantiate(bigMoney, listSpawn[i].position, Quaternion.identity);
                        //    newMoney.SetActive(true);
                        //    break;
                    }

                    listSpawn.RemoveAt(i);
                    i--;
                }

                i++;
            }
        }
    }
}
