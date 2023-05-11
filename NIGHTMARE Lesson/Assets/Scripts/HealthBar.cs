using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    public int totalHealth = 10;

    public void HealthDecreased(int health)
    {
        //totalHealth--;
        totalHealth = health;
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBar.value = totalHealth;
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
