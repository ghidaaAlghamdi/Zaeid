using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

//Screipt to handle updating the user's from the settings
public class UpdateInfo : MonoBehaviour
{
    public InputField Username;
    public InputField OldPassword;
    public InputField NewPassword;
    public Dropdown Grade;
    public Dropdown Character;
    public Canvas err;

    public void CheckPassword() //Enter the old password before updating and check if it's correct
    {
        if(OldPassword.text != "" && OldPassword.text == Login.UserInfo.UserPassword)
        {
            err.gameObject.SetActive(false);
            NewPassword.gameObject.SetActive(true);
        }

    }

    void Update()
    {
        if (NewPassword.isFocused)
        {
            err.gameObject.SetActive(false);
        }
    }

    public void CallEdit()
    {
        StartCoroutine(EditUserInfo());

    }

    public IEnumerator EditUserInfo()
    {
        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

         if(!string.IsNullOrEmpty(Username.text))
         {
            form.AddField("name", Username.text);
         }
         else
        {
            Debug.Log("empty");
        }

         if(!string.IsNullOrEmpty(NewPassword.text))
         {
            form.AddField("password", NewPassword.text);
        }

        
        form.AddField("grade", Grade.options[Grade.value].text);

        if (Character.options[Character.value].text == "ﺪﺋﺍﺯ")
        {
            form.AddField("character", "M");
        }
        else
        {
            form.AddField("character", "F");
        }

        WWW www = new WWW("http://192.168.1.3/Update.php", form);

        yield return www;

        if (www.text[0] == '0')
        {
            Debug.Log("succsess");

        }
        else
        {
            Debug.Log("fail. Error #" + www.text);
        }
    }

    public void CallDelete()
    {
        StartCoroutine(DeleteUserInfo());
    }

    public IEnumerator DeleteUserInfo()
    {
        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

        WWW www = new WWW("http://192.168.1.3/Delete.php", form);

        yield return www;

        if (www.text[0] == '0')
        {
            Debug.Log("succsess");
            SceneManager.LoadScene("login");
        }
        else
        {
            Debug.Log("fail. Error #" + www.text);
        }
    }
}
