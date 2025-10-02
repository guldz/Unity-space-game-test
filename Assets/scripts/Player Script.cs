using UnityEngine;
public class PlayerScript : MonoBehaviour
{
    public float playerspeed = 5;
    public int playerHealth = 3; 
    public GameObject projectile;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         transform.position = new Vector3(0, -3.5f, 0);
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
        playerHealth = playerHealth - damageTaken;
        if(playerHealth <= 0)
        Destroy(gameObject);
        
        

        }

        
       
}