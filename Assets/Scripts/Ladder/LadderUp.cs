using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LadderUp : MonoBehaviour
{
    [SerializeField] GameObject _ladderSpawnPoint;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<CharacterController>().enabled = false;
            other.gameObject.transform.position = _ladderSpawnPoint.transform.position;
            other.gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}
