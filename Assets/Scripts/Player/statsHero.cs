using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class statsHero : MonoBehaviour
{
    private int hp;
    private int scores = 0;
    private bool key = false;

    [SerializeField] Transform respawnPoint;// ����� ������
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
        GetComponent<Death>().respawn();
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
        respawnPoint = newSpawn; // �� ��������, �� ������ ������ ���� ����� � ������� ����� ����� ������. ��� ���������� ����
    }

}
