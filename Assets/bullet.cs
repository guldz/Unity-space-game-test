using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 1.0f; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Destroy(gameObject, 1); 
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime); 

    }
private void OnCollisionEnter2D(Collision2D collision) 
{
  Destroy(gameObject); 
}
}
