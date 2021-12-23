using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LadderUp : MonoBehaviour
{
    [SerializeField] GameObject _ladderSpawnPoint;
    [SerializeField] GameObject _helpText;
    [SerializeField] GameObject player;
    private bool check = false;

    void Update()
    {
        if (check)
        {
            if (Input.GetKey(KeyCode.E))
            {
                player.GetComponent<CharacterController>().enabled = false;
                player.transform.position = _ladderSpawnPoint.transform.position;
                player.GetComponent<CharacterController>().enabled = true;
                _helpText.GetComponent<Text>().text = "";
                check = false;
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
            _helpText.GetComponent<Text>().text = "Нажмите 'E' что подняться";
        }
    }
}
