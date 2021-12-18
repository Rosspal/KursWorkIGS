using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsHero : MonoBehaviour
{
    private int hp;
    private int scores = 0;
    public scoring _scoring;
    public Transform respawnPoint;// точка спавна

    void Start()
    {
        hp = 2;
    }

    void Update()
    {
        if (hp <= 0)
        {
            respawn();
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            hp -= collider.gameObject.GetComponent<enemyStats>().damage;
        }
    }

    void respawn()
    {
        scores = 0;
        hp = 2;
        GetComponent<CharacterController>().enabled = false;
        transform.position = respawnPoint.position;
        GetComponent<CharacterController>().enabled = true;
        _scoring.refresh();
    }

    public int Scores()
    {
        return scores;
    }

    public void Scores(int a)
    {
        scores += a;
    }

    public void NewSpawn(Transform newSpawn)
    {
        respawnPoint = newSpawn; // не проверял, по логике вызови этот метод и передай новую точку спавна. для чекпоинтов надо
    }

}
