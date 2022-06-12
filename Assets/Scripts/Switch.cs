using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using UnityEngine.Networking;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;
public class Switch : MonoBehaviour
{  
  
public GameObject error ;
public GameObject logout ;
public GameObject showComponent ; 
public GameObject c1;
public GameObject c2;
public GameObject c3;
public GameObject c4;
public GameObject c5;
public GameObject c6;
public GameObject c7;
public GameObject c8;
public GameObject c9 ; 
public GameObject levelsMap;
public GameObject level1Map ;
public GameObject level2Map ;
public GameObject level3Map ;
public GameObject level4Map ;
public GameObject level5Map ;
public GameObject level6Map ;

public GameObject back ;
public GameObject outButton;


    public Sprite on ;
    public Sprite of ;
    public Button button;
    public bool isOn = true; 
  
    public AudioSource backgroundSound;
    public AudioSource click ;
    public AudioSource errorSound ; 
    public AudioSource page ; 



    public static int level ;
    static string Level;


       [System.Obsolete]
      void Start()
    {
    
       of = button.image.sprite  ;
       StartCoroutine(GetLevel());

    }

     

    IEnumerator GetLevel()
    {
        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

        WWW www = new WWW("http://192.168.1.3/GetLevel.php", form);

        yield return www;

        level = int.Parse(www.text);

    }

    public void lv1Button(){
    
      click.Play();
      level1Map.SetActive(true);
      back.SetActive(true);
      levelsMap.SetActive(false);
      outButton.SetActive(false);


  }
   public void lv2Button(){
  
     
     if(level>=2){
       click.Play();
      level2Map.SetActive(true);
      back.SetActive(true);
      levelsMap.SetActive(false);
      outButton.SetActive(false);
     }else {
        errorSound.Play();
        error.SetActive(true);

     }   

  }
   public void lv3Button(){

  
     if(level>=3){
       click.Play();
         level3Map.SetActive(true);
      back.SetActive(true);
      levelsMap.SetActive(false);
      outButton.SetActive(false);
     }else {
       errorSound.Play();
        error.SetActive(true);
     }   

  }
   public void lv4Button(){

     
      if(level>=4){
        click.Play();
         level4Map.SetActive(true);
      back.SetActive(true);
      levelsMap.SetActive(false);
      outButton.SetActive(false);
     }else {
       errorSound.Play();
        error.SetActive(true);

     }  
   }
  
   public void lv5Button(){

     
       if(level>=5){
         click.Play();
      level5Map.SetActive(true);
      back.SetActive(true);
      levelsMap.SetActive(false);
      outButton.SetActive(false);
     }else {
       errorSound.Play();
        error.SetActive(true);

     }  
  }

   public void lv6Button(){

       
        if(level>=6){
          click.Play();
         level6Map.SetActive(true);
      back.SetActive(true);
      levelsMap.SetActive(false);
      outButton.SetActive(false);
     }else {
       errorSound.Play();
        error.SetActive(true);

     }  
  }


  public void logoutButton() {
    click.Play();
    logout.SetActive(true);
  }

    public void backButton(){

       click.Play();
       level1Map.SetActive(false);
       level2Map.SetActive(false);
       level3Map.SetActive(false);
       level4Map.SetActive(false);
       level5Map.SetActive(false);
       level6Map.SetActive(false);
       back.SetActive(false);

      levelsMap.SetActive(true);
      outButton.SetActive(true);

    }


     public void questionButton(){

     click.Play();
     showComponent.SetActive(true);
     c1.SetActive(true);

    }

    public void cancelButton(){

        click.Play();
        error.SetActive(false);
        showComponent.SetActive(false);

        c1.SetActive(false);
        c2.SetActive(false);
        c3.SetActive(false);
        c4.SetActive(false);
        c5.SetActive(false);


    }


      public void YesButton(){

        click.Play();
        SceneManager.LoadScene("login");
        

    }

  public void nobutton()
    {
       click.Play();
        logout.SetActive(false);
        showComponent.SetActive(false);
        c1.SetActive(false);
    }


     public void mutebutton() {

        if (isOn){
                button.image.sprite = on ;
                isOn = false;
              backgroundSound.mute = true;

        }else{
                button.image.sprite = of ;
                isOn = true;
              backgroundSound.mute = false;
        }

    }

public void move1to2(){
  page.Play();
  c1.SetActive(false);
  c2.SetActive(true);
  c3.SetActive(false);
}
public void move2to3(){
  page.Play();
  c2.SetActive(false);
  c3.SetActive(true);
  c4.SetActive (false);
}
public void move3to4(){
  page.Play();
  c3.SetActive(false);
  c4.SetActive(true);
  c5.SetActive (false);
}
public void move4to5(){
  page.Play();
  c4.SetActive(false);
  c5.SetActive(true);
  c6.SetActive (false);
}

public void move5to6(){
  page.Play();
  c5.SetActive(false);
  c6.SetActive(true);
   c7.SetActive (false);
}
public void move6to7(){
  page.Play();
  c6.SetActive(false);
  c7.SetActive(true);
  c8.SetActive (false);
}
public void move7to8(){
  page.Play();
  c7.SetActive(false);
  c8.SetActive(true);
  c9.SetActive(false);
}

public void move8to9(){
  page.Play();
  c8.SetActive(false);
  c9.SetActive(true);
}

 public void back2to1(){

     page.Play();
     c1.SetActive(true);
     c2.SetActive(false);

    }

 public void back3to2(){

     page.Play();
     c2.SetActive(true);
     c3.SetActive(false);

    }



}
