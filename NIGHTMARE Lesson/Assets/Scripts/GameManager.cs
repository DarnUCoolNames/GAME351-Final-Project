using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;


public class GameManager : MonoBehaviour
{
    private PlayableDirector currentDirector;
    private bool sceneSkipped = true;
    private float timeToSkipTo;


    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && !sceneSkipped)
        {
            currentDirector.time = 30.0f;
            sceneSkipped = true;
        }

    }
    public void GetDirector(PlayableDirector director)
    {
        sceneSkipped = false;
        currentDirector = director;
    }

    public void GetSkipTime(float skipTime)
    {
        timeToSkipTo = skipTime;
    }

}
