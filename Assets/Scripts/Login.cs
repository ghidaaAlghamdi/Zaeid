using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Text.RegularExpressions;
using System.Linq;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

//This script the user's login process and data
public class Login : MonoBehaviour
{
    public InputField email;
    //Set a pattern for the expected email using regular expression
    public const string EmailPattern =
           @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";
    public InputField password;
    public Canvas emailPopUp;
    public Canvas passwordPopUp;
    public Button submit;
    public Text errmsg;
    public Text info;

    public string UserEmail = "";
    public string UserPassword = "";
    public int id ;
    public static Login UserInfo;


    void Awake()
    {
        UserInfo = this;
    }


    public void CallLogin()
    {
        StartCoroutine(LoginUser());
    }

    //Takes the user's email and password and check for a matching record from the database 
    IEnumerator LoginUser()
    {
        WWWForm form = new WWWForm();
        form.AddField("email", email.text);
        form.AddField("password", password.text);

        WWW www = new WWW("http://192.168.1.3/login.php", form);

        yield return www;

        errmsg.gameObject.SetActive(false);

        if (www.text[0] == '0')
        {
            UserEmail = email.text;
            UserPassword = password.text;
            Debug.Log(UserPassword);
            Debug.Log(UserEmail);
            Debug.Log("Logged in succesfully");
            errmsg.gameObject.SetActive(false);

  
            form.AddField("email", UserEmail);
            www = new WWW("http://192.168.1.3/UserID.php", form);
            yield return www;
            id = int.Parse(www.text);
            SceneManager.LoadScene("HomePage"); //redirect theuser to the homepage after a succesful login 

         
        }
        else
        {
            Debug.Log("Login failed. Error #"+ www.text);
            //Show error message if user's enterd data are invalid
            errmsg.gameObject.SetActive(true);
            errmsg.text = "ﻪﻠﺧﺪﻤﻟﺍ ﺕﺎﻣﻮﻠﻌﻤﻟﺍ ﻦﻣ ﺪﻛﺄﺗ ﺍًﺀﺎﺟﺭ";
        }
    }



   
}
