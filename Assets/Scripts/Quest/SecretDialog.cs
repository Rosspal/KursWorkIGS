using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SecretDialog : MonoBehaviour
{
    [SerializeField] string text = "";
    [SerializeField] string textBefore = "";
    [SerializeField] string item = "";
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
            if (other.gameObject.GetComponent<statsHero>().questItem.Contains(item))
            {
                other.gameObject.GetComponent<statsHero>().questItem.Remove(item);
                first = true;
                check = true;
                _helpText.GetComponent<Text>().text = textBefore;
            }
        }
    }
}
