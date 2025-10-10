using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{ 
public GameObject[] healthimg; 
public int playerHealth = 3; 
//följ koden för kunna sätta in alla tre i canvas brackets eller något idk
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthimg[0].SetActive(true);
        healthimg[1].SetActive(true);
        healthimg[2].SetActive(true);
        
    }       
    
     public void TakingDamage(int damageTaken)
        
        {  
        playerHealth = playerHealth - damageTaken;
        //if(playerHealth <= 2)
        healthimg[0].SetActive(false);
        }
    

    
    //gör kod om <= mindre än 2 lägg health img til .SetActive(false); eller active?
    //if(playerHealth <= 0)
    //healthimg[2].SetActive(false);
     //public void TakingDamage(int damageTaken)
       // {  
       // playerHealth = playerHealth - damageTaken;
        
        
       // }


}
