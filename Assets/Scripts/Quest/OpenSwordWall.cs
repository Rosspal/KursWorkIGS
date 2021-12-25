using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSwordWall : stateOfQuests
{
    [SerializeField] GameObject sword;
    [SerializeField] GameObject wall;

    private float t = 0;
    private float amp = 0.05f;
    private float freq = 0.05f;
    private float offset = 0;
    private bool check = false;



    public override void Start()
    {
        sword.SetActive(false);
    }

    public override void Update()
    {
        if (check)
        {
            t += Time.deltaTime;
            offset = amp * Mathf.Sin(t* freq);
            wall.transform.position += new Vector3(0,-offset,0);
            if (wall.transform.position.y <= -7)
            {
                check = false;
            }
            
        }
    }

    public override void Go()
    {
        sword.SetActive(true);
        check = true;

    }
}
