using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHandling : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Money")
        {
            this.GetComponent<statsHero>().Scores(1);

            switch (this.GetComponent<statsHero>().Scores())
            {
                case 1:
                    this.GetComponent<SoundBox>().Play(5);
                    break;
                case 2:
                    this.GetComponent<SoundBox>().Play(6);
                    break;
                case 3:
                    this.GetComponent<SoundBox>().Play(7);
                    break;
            }

            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "KeyGold")
        {
            this.GetComponent<statsHero>().Key = true;
            this.GetComponent<SoundBox>().Play(3);
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Item")
        {
            //10 11
            this.GetComponent<statsHero>().questItem.Add("Sword");
            switch (Random.Range(1, 3))
            {
                case 1:
                    this.GetComponent<SoundBox>().Play(11);
                    break;
                case 2:
                    this.GetComponent<SoundBox>().Play(12);
                    break;
            }
            Destroy(collider.gameObject);
        }

        if (collider.gameObject.tag == "Enemy")
        {
            this.GetComponent<statsHero>().Hp  -= collider.gameObject.GetComponent<enemyStats>().damage;

            switch (GetComponent<statsHero>().Hp)
            {
                case 1:
                    switch (Random.Range(1, 4))
                    {
                        case 1:
                            this.GetComponent<SoundBox>().Play(3);
                            break;
                        case 2:
                            this.GetComponent<SoundBox>().Play(8);
                            break;
                        case 3:
                            this.GetComponent<SoundBox>().Play(10);
                            break;
                    }
                    break;
                case 2:
                    switch (Random.Range(1, 3))
                    {
                        case 1:
                            this.GetComponent<SoundBox>().Play(1);
                            break;
                        case 2:
                            this.GetComponent<SoundBox>().Play(9);
                            break;
                    }
                    break;
            }

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
