using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneSwitcher : MonoBehaviour
{
    //Script to handle scenes switching
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
