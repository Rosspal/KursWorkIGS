using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiPages : MonoBehaviour
{
    [SerializeField] GameObject Ui1;
    [SerializeField] GameObject Ui2;
    [SerializeField] GameObject Ui3;


    public void ActivePage1()
    {
        Ui1.SetActive(true);
        Ui2.SetActive(false);
        Ui3.SetActive(false);
    }

    public void ActivePage2()
    {
        Ui1.SetActive(false);
        Ui2.SetActive(true);
        Ui3.SetActive(false);
    }

    public void ActivePage3()
    {
        Ui1.SetActive(false);
        Ui2.SetActive(false);
        Ui3.SetActive(true);
    }
}
