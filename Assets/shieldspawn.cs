using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldspawn : MonoBehaviour
{ 
    public GameObject shieldblock;
    public GameObject Player;
    public int shieldcounter=0; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(shieldspawner()); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator shieldspawner()
     {
        while (true)
        {

             if (shieldcounter < 3 && GameObject.Find("Square") != null)
            {
               
                Instantiate(shieldblock, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);

                
                shieldcounter++;

                
                yield return new WaitForSeconds(1);
            }
            else yield return null; 


        }
     }
         
}
