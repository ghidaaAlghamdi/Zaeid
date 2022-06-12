using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

//This script handels accesing the user information from the database to use during the game
public class GetInformation : MonoBehaviour
{
    public static string Level;
    public static string Task;
    public static string Score;
    public string Gender;
    public string SelectedCharacter;
    public static GetInformation Getinfo;


    void Awake()
    {
        Getinfo = this;
    }

    [System.Obsolete]
    void Start()
    {

            StartCoroutine(GetTaskNo());
            StartCoroutine(GetLevel());
            StartCoroutine(GetGender());
            StartCoroutine(GetScores());
            StartCoroutine(GetCharacter());
             
    }



    [System.Obsolete]
   


        public IEnumerator GetTaskNo(){ //Fetching current task

        WWWForm form = new WWWForm();

        form.AddField("UserID", Login.UserInfo.id);

            UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetTask.php", form);
      
            yield return www.SendWebRequest() ;


            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
               

            }
            else
            {
            
               Task=www.downloadHandler.text;

            }

        }
         [System.Obsolete]
        public IEnumerator GetGender(){ //Fetching the user gender

        WWWForm form = new WWWForm();

          form.AddField("UserID", Login.UserInfo.id);

            UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetGender.php", form);
      
            yield return www.SendWebRequest() ;


            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
               

            }
            else
            {
               Gender=www.downloadHandler.text;
            }

        }

    [System.Obsolete]
    public IEnumerator GetCharacter() //Fetching the chosen character
    {

        WWWForm form = new WWWForm();

        form.AddField("UserID", Login.UserInfo.id);

        UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetCharacter.php", form);

        yield return www.SendWebRequest();


        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);

        }
        else
        {
            SelectedCharacter = www.downloadHandler.text;
        }

    }

    [System.Obsolete]

          public IEnumerator GetScores(){ //Fetching current score

        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

            UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetScore.php", form);
      
            yield return www.SendWebRequest() ;


            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
               

            }
            else
            {
               Score = www.downloadHandler.text;
            }

              

        }

 [System.Obsolete]
         public IEnumerator GetLevel(){ //Fetching current level

        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

            UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetLevel.php", form);
      
            yield return www.SendWebRequest() ;


            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
               

            }
            else
            {
               Level=www.downloadHandler.text;

            }

        }
 

        

    }


