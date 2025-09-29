using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
 public GameObject enemyShip;
    private int enemyCounter=0; 
    private GameObject player;
    
    void Start()
    {
         
        StartCoroutine(EnemySpawner());
    }

    
    void Update()
    {
        
    }

    
    IEnumerator EnemySpawner()
    {
        
        
        while(true)
        {
            
            if (enemyCounter < 3 && GameObject.Find("Square") != null)
            {
               
                Instantiate(enemyShip, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);

                
                enemyCounter++;

                
                yield return new WaitForSeconds(5);
            }
            else yield return null; 
            
            
        }
    }
}