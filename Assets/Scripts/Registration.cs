using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
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

public class Registration : MonoBehaviour
{

    public InputField username;
    public InputField email;
    public InputField password1;
    public InputField password2;
    public Dropdown Grade;
    public Dropdown Gender;
    public InputField usernameErr;
    public InputField emailErr;
    public InputField password1Err;
    public InputField password2Err;
    public Canvas usernamePopUp;
    public Canvas emailPopUp;
    public Canvas emailExistPopUp;
    public Canvas password1PopUp;
    public Canvas password2PopUp;

    int ifEmailExist;

    //Set a pattern for the expected email using regular expression
    public const string EmailPattern =
           @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@"
           + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\."
             + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|"
           + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";

    public Button submit;
    public static Registration registration;

    void Awake()
    {
        registration = this;
    }

    //Check the entered username 
    public bool UsernameCheck(string un)
    {
        
        if (un.Length > 5 && Regex.Match(un, "^[\u0621-\u064A0-9 ]+$").Success) //Correct username format
        {
            usernamePopUp.gameObject.SetActive(false);
            return true;
        }
        else if(un == "") 
        {
            usernamePopUp.gameObject.SetActive(false);
        }

        else  //Incorrect username format
        {
            usernamePopUp.gameObject.SetActive(true);
            return false;
        }
        return false;
    }

    //Check if entered email exists or not
    IEnumerator CheckEmail()
    {
        WWWForm form = new WWWForm();
        form.AddField("Email", email.text);

        WWW www = new WWW("http://192.168.1.3/CheckEmail.php", form);

        yield return www;

        if (www.text == "1") //user with email dosen't exist
        {
            ifEmailExist = 1;
        }
        else //user with email exist
        {
            ifEmailExist = 0;
        }
    }

    //Check the entered email
    public bool EmailCheck(string em)
    {
        StartCoroutine(CheckEmail());


        if (ifEmailExist == 0)//if user with email exist show error message
        {
            emailExistPopUp.gameObject.SetActive(true);
        }
        else if(em == "")
        {
            emailExistPopUp.gameObject.SetActive(false);
        }
        else if(ifEmailExist >= 1 ) //if user with email dosen't exist hide error message
        {
            emailExistPopUp.gameObject.SetActive(false);

            if (Regex.Match(em, EmailPattern).Success) //Correct email format
            {
                emailPopUp.gameObject.SetActive(false);
                return true;
            }
            else if (em == "")
            {
                emailPopUp.gameObject.SetActive(false);
            }
            else //Incorrect email format
            {
                emailPopUp.gameObject.SetActive(true);
                return false;
            }
        }

        return false;
    }

    //Check the entered password
    public bool PasswordCheck(string ps1)
    {
        if (ps1.Length > 7 && ps1.Any(char.IsUpper) && ps1.Any(char.IsDigit) && ps1.Any(char.IsSymbol)) //Correct password format
        {
            password1PopUp.gameObject.SetActive(false);
            return true;
        }
        else if (ps1 == "")
        {
            password1PopUp.gameObject.SetActive(false);
        }
        else
        {
            password1PopUp.gameObject.SetActive(true); //Incorrect password format
            return false;
        }
        return false;
    }

    //Check if the entered password and password confermation matches 
    public bool PasswordMatch(string ps2)
    {

        if (ps2 != "" && ps2 == password1.text) //Matched passwords
        {
            password2PopUp.gameObject.SetActive(false);
            return true;
        }
        else if (ps2 == "")
        {
            password2PopUp.gameObject.SetActive(false);
        }
        else //unmatched passwords
        {
            password2PopUp.gameObject.SetActive(true);
            return false;
        }
        return false;
    }


    public void CallRegister()
    {
        StartCoroutine(Register());
    }

    IEnumerator Register()
    {
        WWWForm form = new WWWForm();
        //Send registered user's info to store in the database
        form.AddField("name", username.text);
        form.AddField("email", email.text);
        form.AddField("password", password1.text);
        form.AddField("grade", Grade.options[Grade.value].text);
        form.AddField("gender", Gender.options[Gender.value].text);


        WWW www = new WWW("http://192.168.1.3/register.php", form);
        yield return www;

        if(www.text == "0")
        {
            Debug.Log("User Created Succefuly");
            SceneManager.LoadScene("Character");

        }
        else
        {
            Debug.Log("User creation failed. Error #" + www.text);
        }
    }

    //Check for user's input format and validity
    public void Verifyinputs()
    {
        submit.interactable = (UsernameCheck(username.text) && EmailCheck(email.text) && PasswordCheck(password1.text) && PasswordMatch(password2.text));
    }
}
