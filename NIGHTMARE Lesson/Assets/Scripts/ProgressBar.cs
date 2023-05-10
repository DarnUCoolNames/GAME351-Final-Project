using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider progressBar;
    public int totalEnemies;
    private int enemiesDestroyed;

    public void EnemyDestroyed()
    {
        enemiesDestroyed++;
        UpdateProgressBar();
    }

    private void UpdateProgressBar()
    {
        progressBar.value = enemiesDestroyed;
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
