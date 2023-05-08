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
        progressBar.value = (float)enemiesDestroyed / totalEnemies;
    }
}


/*
Add this to code where enemies will be deleted 

GameObject progressBar = GameObject.Find("Slider"); // Replace "Slider" with the name of your slider GameObject
ProgressBar progressBarScript = progressBar.GetComponent<ProgressBar>();
progressBarScript.EnemyDestroyed();

*/
