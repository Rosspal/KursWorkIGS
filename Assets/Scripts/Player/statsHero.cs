using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsHero : MonoBehaviour
{
    private int hp;
    private int scores = 0;
    private bool key = false;

    [SerializeField] scoring _scoring;
    [SerializeField] Transform respawnPoint;// точка спавна
    public ArrayList questItem = new ArrayList();



    public bool Key { get => key; set => key = value; }
    public int Hp { get => hp; set => hp = value; }

    void Start()
    {
        hp = 3;
    }

    void Update()
    {
        if (hp <= 0)
        {
            respawn();
        }
    }

    public int getHp()
    {
        return hp;
    }


    public void respawn()
    {
        scores = 0;
        hp = 3;
        GetComponent<CharacterController>().enabled = false;
        transform.position = respawnPoint.position;
        GetComponent<CharacterController>().enabled = true;
    }

    public int Scores()
    {
        return scores;
    }

    public void Scores(int a)
    {
        scores += a;
    }

    public void StopLevel()
    {
        GetComponent<LevelTimer>().stop();
        GetComponent<TrigersSave>().SaveInfo();
        GetComponent<Save>().SaveToFile();
    }

    public void NewSpawn(Transform newSpawn)
    {
        respawnPoint = newSpawn; // не проверял, по логике вызови этот метод и передай новую точку спавна. для чекпоинтов надо
    }

}
