using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyKey : MonoBehaviour
{
    [SerializeField] AudioSource audioKey;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "KeyGold")
        {
            this.GetComponent<statsHero>().Key = true;
           // audioKey.Play();
            Destroy(collider.gameObject);
        }
    }
}
