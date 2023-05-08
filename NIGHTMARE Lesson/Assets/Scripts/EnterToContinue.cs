using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterToContinue : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SceneManager.LoadScene("MainMenu"); 
        }
    }
}