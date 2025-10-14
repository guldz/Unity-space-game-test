using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;
public class gameoverscreen : MonoBehaviour

{
    public int playerHealth = 3; 
    public void RestartGame() 
  {
    SceneManager.LoadSceneAsync(1);
  }

  public void MainMenu() 
  {
    SceneManager.LoadSceneAsync(0);
  }

    public void TakingDamage(int damageTaken) 
    {
        if(playerHealth <= 0)
        SceneManager.LoadSceneAsync(2);
    }    
  
  
}
