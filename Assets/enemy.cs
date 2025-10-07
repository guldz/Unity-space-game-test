using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed; 
    public GameObject scoremanager;
    EnemySpawnScript espawn; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        espawn = GameObject.Find("enemyspawner").GetComponent<EnemySpawnScript>(); 
        scoremanager = GameObject.Find("Canvas"); 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    
        if(transform.position.y <= -5.5f) 
        {
            transform.position = new Vector3 (Random.Range (-8, 8), 5.5f, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            other.transform.GetComponent<PlayerScript>().TakingDamage(1);
            Debug.Log("Hit: " + other);
            espawn.enemyCounter = espawn.enemyCounter - 1; 
            Destroy(gameObject); 
        }
        if(other.tag == "Bullet")
        {
            Debug.Log("Hit by " + other);
            espawn.enemyCounter = espawn.enemyCounter - 1; 
            scoremanager.GetComponent<ScoreManager>().UpdateScore(1);
            Destroy(gameObject); 
        }
        
        
    }
}
