using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Dialogs : MonoBehaviour
{
    [SerializeField] string text = "";
    [SerializeField] GameObject _helpText;
    [SerializeField] stateOfQuests quest;
    private bool check = false;
    private bool first = true;


    void Update()
    {
        if (check)
        {
            if (Input.GetKey(KeyCode.E))
            {
                _helpText.GetComponent<Text>().text = text;
                if (first)
                {
                    first = false;
                    quest.Go();
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
            _helpText.GetComponent<Text>().text = "Говорить 'E'";
        }
    }
}
