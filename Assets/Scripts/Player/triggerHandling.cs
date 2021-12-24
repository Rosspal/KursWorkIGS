using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHandling : MonoBehaviour
{
    [SerializeField] AudioSource audioMoney;
    //[SerializeField] AudioSource audioKey;
    //[SerializeField] AudioSource audioItem;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Money")
        {
            audioMoney.Play();
            this.GetComponent<statsHero>().Scores(1);
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "KeyGold")
        {
            this.GetComponent<statsHero>().Key = true;
            //audioKey.Play();
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Item")
        {
            this.GetComponent<statsHero>().questItem.Add("Sword");
            //audioItem.Play();
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Enemy")
        {
            this.GetComponent<statsHero>().Hp  -= collider.gameObject.GetComponent<enemyStats>().damage;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "LevelStart")
        {
            this.GetComponent<LevelTimer>().start();
        }
    }
}
