using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class switching : MonoBehaviour
{
    public GameObject backPopup; 


    AudioSource[] allAudioSources;

    void Start()
    {
    allAudioSources = Object.FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
    }
 
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void showPopup()
    {
        backPopup.SetActive(true);
        Time.timeScale=0;
        foreach (AudioSource audio in allAudioSources)
        {
            if(audio.GetComponent<AudioSource>().isPlaying)
            audio.GetComponent<AudioSource>().Pause();
        }
    }

    public void hidePopup()
    {
        backPopup.SetActive(false);
        Time.timeScale=1;
        foreach (AudioSource audio in allAudioSources)
        {
            if(!audio.GetComponent<AudioSource>().isPlaying)
            audio.GetComponent<AudioSource>().UnPause();
        }
    }
}
