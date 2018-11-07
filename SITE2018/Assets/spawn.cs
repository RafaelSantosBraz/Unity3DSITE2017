using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{

    public GameObject enemyPreFab;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("toSpawn", 1, 1);
    }

    void toSpawn()
    {
        //Instantiate(this, transform);
        for (int i = 0; i < 100; i++)
        {
            Instantiate(enemyPreFab, transform);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
