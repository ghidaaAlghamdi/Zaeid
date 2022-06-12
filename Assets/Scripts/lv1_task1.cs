using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

public class lv1_task1 : MonoBehaviour
{
    //environment sounds
    public AudioSource zaeidquestion ;
    public AudioSource zainahquestion ;
    public AudioSource click ;
    public AudioSource popUp;

   //environment animators
    public Animator zaeidAn;
    public Animator zainahAn;

   //environment gameObjects
    public GameObject pan1;
    public GameObject pan2;
    public GameObject pan3;
    public GameObject table;
    public GameObject book;
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject teacher;
    public GameObject button1 ;
    public GameObject button2 ;
    



     public lv1_intro Intro;
    public GameObject IntroEnv;
    public GameObject IntroCnvas;
    
    
     int Scores;
     int sc;




 [System.Obsolete]
 


     
    void Start()
    {
        StartCoroutine(lvlController());
}



    IEnumerator lvlController()
    {

        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

        WWW www = new WWW("http://192.168.1.3/GetScore.php", form);

        yield return www;

        string en = "";

        for (int i = 0; i < www.text.Length; i++)
        {
            en += char.GetNumericValue(www.text, i);
        }

        sc = int.Parse(en);


        Intro = GameObject.FindGameObjectWithTag("intro1").GetComponent<lv1_intro>();

        if (sc == 0)
        {
            Intro.PlayIntro();
        }
        else if (sc > 0)
        {
            StartCoroutine(WaitBeforeShowpop());
        }

    }
    public IEnumerator WaitBeforeShowpop()
    {

        IntroEnv.SetActive(false);
        IntroCnvas.SetActive(false);

        if (GetInformation.Getinfo.SelectedCharacter == "F")
        {

            yield return new WaitForSeconds(3);
            popUp.Play();
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            teacher.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            table.SetActive(true);
            zainahAn.SetTrigger("talk");
            zainahquestion.Play();
            yield return new WaitForSeconds(4);
            popUp.Play();
            book.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            pan1.SetActive(true);
            pan2.SetActive(true);
            pan3.SetActive(true);
            yield return new WaitForSeconds(5);
            zainahAn.SetTrigger("smile");
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            button1.SetActive(true);
            yield return new WaitForSeconds(2);
            popUp.Play();
            button2.SetActive(true);


        }
        else if (GetInformation.Getinfo.SelectedCharacter == "M")
        {


            yield return new WaitForSeconds(3);
            popUp.Play();
            zaeid.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            teacher.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            table.SetActive(true);
            zaeidAn.SetTrigger("talk");
            zaeidquestion.Play();
            yield return new WaitForSeconds(4);
            popUp.Play();
            book.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            pan1.SetActive(true);
            pan2.SetActive(true);
            pan3.SetActive(true);
            yield return new WaitForSeconds(6);
            zaeidAn.SetTrigger("smile");
            zaeid.SetActive(true);
            //canva.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            button1.SetActive(true);
            yield return new WaitForSeconds(2);
            popUp.Play();
            button2.SetActive(true);



        }
    }

  
}
