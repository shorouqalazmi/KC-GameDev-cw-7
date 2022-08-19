using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamacontroler : MonoBehaviour
{
    public Transform spawn;
    public Transform spawnright;
    public Transform spawnleft;
    public float delay;
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy",0f,delay); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void spawnenemy()
    {
        int randNum = Random.Range(1,4); //number between 1 and 3 (excluding4)
        if(randNum == 1)
        {
            Instantiate(enemy,spawn);
        }
         else if(randNum == 2)
        {
             Instantiate(enemy,spawnleft);
        }
         else
        {
              Instantiate(enemy,spawnright);
        }
    }        
}