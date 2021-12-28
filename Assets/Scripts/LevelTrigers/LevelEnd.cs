using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelEnd : MonoBehaviour
{
    [SerializeField] GameObject _helpText;
    [SerializeField] Animator anim;
    [SerializeField] GameObject sh;
    private bool key = false;
    private bool check = false;

    void Start()
    {
        anim.enabled = false;
    }

    void Update()
    {
        if (check)
        {
            if (key)
            {
                if (Input.GetKey(KeyCode.E))
                {
                    Debug.Log("1 - " + _helpText.GetComponent<Text>().text);
                    _helpText.GetComponent<Text>().text = "Победа!";
                    Debug.Log("2 - " + _helpText.GetComponent<Text>().text);
                    sh.GetComponent<statsHero>().StopLevel();
                    anim.enabled = true;
                    GetComponent<TimerLevelEnd>().start();
                }
            }
        } 
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            check = true;
            if (other.gameObject.GetComponent<statsHero>().Key)
            {
                sh = other.gameObject;
                _helpText.GetComponent<Text>().text = "Нажмите Е что бы открыть";
                key = true;
            }
            else
            {
                _helpText.GetComponent<Text>().text = "Чёрт! без ключа не открыть";
                other.gameObject.GetComponent<SoundBox>().Play(2);
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
}
