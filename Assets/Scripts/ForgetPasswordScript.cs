using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ForgetPasswordScript : MonoBehaviour
{
   
   public AudioSource click ;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void send(){
    
     click.Play();
    //SceneManager.LoadScene("Homepage");
    }

    public void exsit(){
    
     click.Play();
    SceneManager.LoadScene("Login");
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
