using UnityEngine;
using UnityEngine.UI;
using TMPro; // Add this namespace

public class ProgressBar : MonoBehaviour
{
    public Slider progressBar;
    public int totalEnemies = 10;
    private int enemiesDestroyed;
    public TextMeshProUGUI completionText;

    private void Start()
    {
        completionText.enabled = false;
    }


    public void EnemyDestroyed()
    {
        enemiesDestroyed++;
        UpdateProgressBar();
    }

    private void UpdateProgressBar()
    {
        progressBar.value = enemiesDestroyed;

        if (enemiesDestroyed == totalEnemies)
        {
            completionText.enabled = true;
        }
    }
}


/*
Add this to code where enemies will be deleted 

GameObject progressBar = GameObject.Find("progressSlider"); 
ProgressBar progressBarScript = progressBar.GetComponent<ProgressBar>();
progressBarScript.EnemyDestroyed();

Build completed with a result of 'Failed' in 7 seconds (6839 ms)
UnityEngine.GUIUtility:ProcessEvent (int,intptr,bool&)

*/
