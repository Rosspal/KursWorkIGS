using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TreeZone : MonoBehaviour
{
    [SerializeField] GameObject _helpText;
    [SerializeField] GameObject _countPresents;
    [SerializeField] GameObject _present1;
    [SerializeField] GameObject _present2;
    [SerializeField] GameObject _present3;
    [SerializeField] GameObject sh;

    bool check;
    int count;

    void Update()
    {
        if (check)
        {
            if (Input.GetKey(KeyCode.E))
            {
                count = Convert.ToInt32(_countPresents.GetComponent<Text>().text);
                switch (count)
                {
                    case 0:
                        _helpText.GetComponent<Text>().text = "�� ��� �� ����� �������";
                        break;
                    case 1:
                        _helpText.GetComponent<Text>().text = "������ ��� ������ �������";
                        _present1.SetActive(true);
                        break;
                    case 2:
                        _helpText.GetComponent<Text>().text = "�������� ����� ���� �������";
                        _present1.SetActive(true);
                        _present2.SetActive(true);
                        break;
                    case 3:
                        _helpText.GetComponent<Text>().text = "�� ������ ��������� � ���!!\n������!!!";
                        _present1.SetActive(true);
                        _present2.SetActive(true);
                        _present3.SetActive(true);
                        sh.GetComponent<statsHero>().StopLevel();
                        GetComponent<TimerLevelEnd>().start();
                        break;
                }
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            check = false;
            _helpText.GetComponent<Text>().text = "";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            check = true;
            _helpText.GetComponent<Text>().text = "�������� ������� 'E'";
        }
    }
}
