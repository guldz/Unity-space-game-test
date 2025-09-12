using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
    private void OnTriggerEnter2d(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Hit: " + other); 
        }
        if(other.tag == "Laser")
        {
            Destroy(gameObject); 
        }
        
    }
}
