using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 1.0f; 
    public int playerHealth =3;
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
private void OnTriggerEnter2D(Collider2D other)
{
  if (other.tag == "enemy")
{
  Debug.Log("Hit: " + other);
  Destroy(gameObject); 
}

}

}
