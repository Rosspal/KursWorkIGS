using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    public Transform point; // куда тп делать

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            collider.gameObject.GetComponent<CharacterController>().enabled = false;
            collider.gameObject.transform.position = point.position;
            collider.gameObject.GetComponent<CharacterController>().enabled = true;
        }
    }
}
