using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LadderUp : MonoBehaviour
{
    [SerializeField] GameObject _ladderSpawnPoint;
    [SerializeField] GameObject _helpText;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _helpText.GetComponent<Text>().text = "Press E to use Ladder";
            if (Input.GetKeyDown(KeyCode.E))
            {
                other.gameObject.GetComponent<CharacterController>().enabled = false;
                other.gameObject.transform.position = _ladderSpawnPoint.transform.position;
                other.gameObject.GetComponent<CharacterController>().enabled = true;
                _helpText.GetComponent<Text>().text = "";
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _helpText.GetComponent<Text>().text = "";
        }
    }
}
