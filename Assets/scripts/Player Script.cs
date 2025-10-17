using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    public float playerspeed = 5;
    public int playerHealth = 3; 
    public GameObject projectile;
    public GameObject health; 
    public GameObject shield; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         shield.SetActive(false);
         transform.position = new Vector3(0, -3.5f, 0);
         health = GameObject.Find("Canvas");
         //sätt en timer och coroutine som i enemyspawner utan någon if och while 
         //StartCoroutine(shield()); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerspeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeed * Time.deltaTime);

        }
        if(transform.position.x<= -11){
        transform.position = new Vector3(10.9f, transform.position.y,0);

        }
        if(transform.position.x>= 11){
        transform.position = new Vector3(-10.9f, transform.position.y,0);
        
        }  if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(projectile, this.transform.position, this.transform.rotation);
        }
        
       
        
        
    }
        public void TakingDamage(int damageTaken)
        {
        //kör TakingDamage(skada) i healthbar.cs
        health.transform.GetComponent<healthbar>().TakingDamage(damageTaken); 
        playerHealth = playerHealth - damageTaken;
        if(playerHealth <= 0)     
        {
        Destroy(gameObject);
        SceneManager.LoadSceneAsync(2);
        }
        }
        

        
       
}