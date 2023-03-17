using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    
    
    [SerializeField]
    GameObject enemyPrefab;

    float spawntimer = 0;

    [SerializeField]
    float timeBetweenEnemySpawns = 1f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        spawntimer += Time.deltaTime;
        
        if(spawntimer > timeBetweenEnemySpawns)
        {
            Instantiate(enemyPrefab);
            spawntimer = 0;

        }

    }
}
