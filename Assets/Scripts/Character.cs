using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

public class Character : MonoBehaviour
{
    string selectedCharacter;
    public GameObject ConfermationMsg;
    public AudioSource Pop;
  [System.Obsolete]
    public void CallZaeid() //called when choosing "Zaeid" as a character
    {
        selectedCharacter = "M";
        StartCoroutine(ChooseCharacter());
        StartCoroutine(wait());
        SceneManager.LoadScene("Login");
    }
 [System.Obsolete]
    public void CallZaina() //called when choosing "Zaina" as a character
    {
        selectedCharacter = "F";
        StartCoroutine(ChooseCharacter());
        StartCoroutine(wait());
        SceneManager.LoadScene("Login");
    }

    IEnumerator wait() //Shows confermation message after choosing a character and wait for seconds before redirecting the user
    {
        Pop.Play();
        ConfermationMsg.SetActive(true);
        yield return new WaitForSeconds(3);
    }

    [System.Obsolete]
    //Sets a character to the user after the user chooses one
    IEnumerator ChooseCharacter()
    {
        WWWForm form = new WWWForm();
        form.AddField("Email", Registration.registration.email.text); 
        form.AddField("Character", selectedCharacter);

        WWW www = new WWW("http://192.168.1.3/Character.php", form);

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


}
