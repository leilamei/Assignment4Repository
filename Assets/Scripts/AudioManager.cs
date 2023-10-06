using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource Intro;
    public AudioSource NormalState;

    // Start is called before the first frame update
    void Start()
    {
        
        Intro.Play(); //play the intro bgm with play is pressed

        
        StartCoroutine(SwitchToNormalStateAfterDelay(5f)); //start 'coroutine' to switch after 5 seconds
    }

    
    IEnumerator SwitchToNormalStateAfterDelay(float delay) //'coroutine' to switch
    {
        
        yield return new WaitForSeconds(delay); //wait for delay before the normal state bgm

        
        Intro.Stop(); //stop the intro music
        NormalState.Play(); //play the normal state bgm
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
