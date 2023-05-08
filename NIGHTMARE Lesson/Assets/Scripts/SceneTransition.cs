using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public void LoadGameScene()
    {
        SceneManager.LoadScene("School"); // Replace "GameScene" with the name of your game scene
    }
}
