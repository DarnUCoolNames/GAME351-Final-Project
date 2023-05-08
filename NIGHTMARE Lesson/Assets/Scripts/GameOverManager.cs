using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public bool isGameOver = false; // Set this to true when the player dies in your game

    void Update()
    {
        if (isGameOver)
        {
            StartCoroutine(WaitAndLoadGameOverScene());
        }
    }

    IEnumerator WaitAndLoadGameOverScene()
    {
        float waitTime = 5f;
        yield return new WaitForSeconds(waitTime);
        
        SceneManager.LoadScene("GameOver"); 
    }
}