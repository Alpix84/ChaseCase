using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void LevelWon(){
        completeLevelUI.SetActive(true);
    }

    public void GameOver(){
        if (!gameHasEnded){
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart",restartDelay);
        }
    }

    void Restart(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
