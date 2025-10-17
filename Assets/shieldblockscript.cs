using UnityEngine;

public class shieldblockscript : MonoBehaviour
{
    public float speed; 
    shieldspawn shspawn;
    public GameObject shield;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        shspawn =  GameObject.Find("SheildSpawn").GetComponent<shieldspawn>();
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
            Destroy(gameObject); 
        }
        {
         shield.SetActive(true);

        }
        if(other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
