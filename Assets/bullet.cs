using UnityEngine;

public class bullet : MonoBehaviour
{
    public float bulletSpeed = 1.0f; 
    public GameObject scoremanager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      Destroy(gameObject, 1); 
      scoremanager = GameObject.Find("Canvas");  
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime); 

    }
private void OnCollisionEnter2D(Collision2D collision) 
{
  scoremanager.GetComponent<ScoreManager>().UpdateScore(10);
  Destroy(gameObject); 
}

}
