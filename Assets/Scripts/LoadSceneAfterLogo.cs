using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class LoadSceneAfterLogo : MonoBehaviour
{
    public VideoPlayer VideoPlayer1;
    public VideoPlayer VideoPlayer2; // Drag & Drop the GameObject holding the VideoPlayer component
    public GameObject skipbtn;

    void Start()
    {
        VideoPlayer1.loopPointReached += LoadIntro;
    }

    void LoadIntro(VideoPlayer vp)
    {
        skipbtn.gameObject.SetActive(true);
        //VideoPlayer1.gameObject.SetActive(false);
        VideoPlayer2.gameObject.SetActive(true);
        VideoPlayer2.loopPointReached += LoadScene;
    }
    void LoadScene(VideoPlayer vp)
    {
        skipbtn.gameObject.SetActive(false);
        SceneManager.LoadScene("signup");
    }

    public void skip()
    {
        skipbtn.gameObject.SetActive(false);
        SceneManager.LoadScene("signup");
    }

 
    // void Start()
    // {
    //     VideoPlayer1.loopPointReached += LoadIntro;
    // }
    // void LoadIntro()
    // {
    //     VideoPlayer2.loopPointReached += LoadSignup;
    // }

    //     void LoadSignup()
    // {
    //     SceneManager.LoadScene("signup");
    // }
}