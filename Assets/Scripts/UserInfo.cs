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

public class UserInfo : MonoBehaviour
{

    public Text username;
    public Text grade;
    public Text character;
    public static UserInfo userinfo;

    void Awake()
    {
        userinfo = this;
    }

    void Start()
    {
        StartCoroutine(GetUserInfo());
        userinfo = this;
    }

    void Update(){
    StartCoroutine(GetUserInfo());   
    }

    IEnumerator GetUserInfo()
    {
        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

        WWW www = new WWW("http://192.168.1.3/UserInfo.php", form);

        yield return www;

        string[] result = www.text.Split('\t');

        username.text = result[0];
        grade.text = result[1];


        if (result[2] == "M")
        {
            character.text = "ﺪﺋﺍﺯ";
        }
        else
        {
            character.text = "ﺔﻨﻳﺯ";
        }

    }


   


}
