using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject enemy; 
    private int enemyCounter; 
    private GameObject Player; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine (EnemySpanwer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator EnemySpanwer ()
    {
        while(true)
    }
    if (enemyCounter < 3 && GameObject.Find("Player") !=null) 
    {
        Instantiate(enemy, new Vector3 (Random.Range(-8, 8), 7, 0), Quaternion.identity);
        enemyCounter++; 
        yield return new WaitForSeconds (5);
    }
    else yield return null; 
    
}
