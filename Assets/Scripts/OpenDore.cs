using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenDore : MonoBehaviour
{
    [SerializeField] GameObject _helpText;
    [SerializeField] GameObject _dore;
    private bool check = false;
    private bool open = false;
    Quaternion newQuaternion = new Quaternion();

    void FixedUpdate()
    {
        if (check)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {


            }
        }
    }

    private Quaternion Change(float x, float y, float z)
    {
        newQuaternion.Set(x, y, z, 1);
        return newQuaternion;
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
            _helpText.GetComponent<Text>().text = "Открыть 'E'";
        }
    }
}
