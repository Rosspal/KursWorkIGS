using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsHero : MonoBehaviour
{
    private int hp;
    private int scores = 0;
    public scoring _scoring;
    public Transform respawnPoint;// ����� ������
    [SerializeField] LevelTimer time;
    [SerializeField] TrigersSave trigersSave;
    [SerializeField] Save save;
    [SerializeField] NextScene NextScene;

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

        if (collider.gameObject.tag == "LevelEnd")
        {
            time.stop();
            trigersSave.SaveInfo();
            save.SaveToFile();
            NextScene.nextScene();
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
        respawnPoint = newSpawn; // �� ��������, �� ������ ������ ���� ����� � ������� ����� ����� ������. ��� ���������� ����
    }

}
