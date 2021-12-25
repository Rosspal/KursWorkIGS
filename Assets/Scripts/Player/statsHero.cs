using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsHero : MonoBehaviour
{
    private int hp;
    private int scores = 0;
    private bool key = false;
    public Transform respawnPoint;// точка спавна
    [SerializeField] LevelTimer time;
    [SerializeField] TrigersSave trigersSave;
    [SerializeField] Save save;
    [SerializeField] NextScene NextScene;

    public bool Key { get => key; set => key = value; }

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

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Enemy")
        {
            hp -= collider.gameObject.GetComponent<enemyStats>().damage;
        }

        if (collider.gameObject.tag == "KeyGold")
        {
            
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "LevelStart")
        {
            time.start();
        }
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
        time.stop();
        trigersSave.SaveInfo();
        save.SaveToFile();
    }

    public void NewSpawn(Transform newSpawn)
    {
        respawnPoint = newSpawn; // не проверял, по логике вызови этот метод и передай новую точку спавна. для чекпоинтов надо
    }

}
