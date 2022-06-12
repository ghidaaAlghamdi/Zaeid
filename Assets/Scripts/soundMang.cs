using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundMang : MonoBehaviour
{

 private void Awake()
    {

        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("music");
      
        if(musicObj.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);

    }

}
