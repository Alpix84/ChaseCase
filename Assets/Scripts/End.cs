using UnityEngine;

public class End : MonoBehaviour
{
    public GameManager gameManager;

    void OnTriggerEnter(){
        gameManager.LevelWon();
    }
}
