using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLevel : MonoBehaviour
{
    int _count;
    [SerializeField] int _needCount;
    [SerializeField] GameObject _gameObject;
    private void Start()
    {
        for (int i =1;i<=3;i++)
        {
            PlayerPreferens.LevelInfo it = (PlayerPreferens.LevelInfo)PlayerPreferens.list[i];
            _count += it.money;
        }
    }

    private void Update()
    {
        if (_count >= _needCount)
        {
            _gameObject.SetActive(false);
            Debug.Log("Сделал");
        }
    }
}
