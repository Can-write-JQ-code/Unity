using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restarDelay = 1.0f;

    bool gameHasEnded = false;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }  
   

    //  ”Œœ∑ ß∞‹
    public void EndGame()
    {
       
        if (gameHasEnded == false )
        {
            gameHasEnded = true;
            Debug.Log("Game OVER");
            Invoke("Restart", restarDelay);
        }
        
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
