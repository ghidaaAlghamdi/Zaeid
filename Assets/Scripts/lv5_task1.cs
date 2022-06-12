using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

public class lv5_task1 : MonoBehaviour
{
    //all animator   
    public Animator zaeidAn;
    public Animator zainahAn;
    public Animator shopCakes;
    public Animator custOrders;
    //all objects   
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject cashier;
    public GameObject customer;
    public GameObject shopCake;
    public GameObject custOrder;
    public GameObject num_3;
    public GameObject minusSign;
    public GameObject num_1;
    //answers
    public GameObject wAnswer1;
    public GameObject cAnswer;
    public GameObject wAnswer2;
    //all audios
    public AudioSource click;
    public AudioSource popUp;
    public AudioSource ZaeidT1;
    public AudioSource ZainahT1;

    public l5intro Intro;
    public GameObject IntroEnv;
    public GameObject IntroCnvas;


     int Scores;
     int sc;



    void Start()
    {

        StartCoroutine(lvlController());
    }

    public IEnumerator lvlController()
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

        Intro = GameObject.FindGameObjectWithTag("intro5").GetComponent<l5intro>();

        if (sc == 120)
        {
            Intro.PlayIntro();
        }
        else if (sc > 120)
        {
            StartCoroutine(WaitBeforeShowpop());
        }

    }

    public IEnumerator WaitBeforeShowpop()
    {

        
            IntroEnv.SetActive(false);
            IntroCnvas.SetActive(false);

       
      

        if (GetInformation.Getinfo.SelectedCharacter=="M")
        {
            zaeid.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            cashier.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            customer.SetActive(true);
            yield return new WaitForSeconds(1);
            zaeidAn.SetTrigger("talk");
            ZaeidT1.Play();
            yield return new WaitForSeconds(1);
            shopCake.SetActive(true);
            yield return new WaitForSeconds(4);
            custOrder.SetActive(true);
            yield return new WaitForSeconds(4);
            num_3.SetActive(true);
            yield return new WaitForSeconds(1);
            minusSign.SetActive(true);
            yield return new WaitForSeconds(1);
            num_1.SetActive(true); 
            zaeidAn.SetTrigger("smile");
        
        }
        else 
        {
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            cashier.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            customer.SetActive(true);
            yield return new WaitForSeconds(1);
            zainahAn.SetTrigger("talk");
            ZainahT1.Play();
            yield return new WaitForSeconds(1);
            shopCake.SetActive(true);
            yield return new WaitForSeconds(3);
            custOrder.SetActive(true);
            yield return new WaitForSeconds(4);
            num_3.SetActive(true);
            yield return new WaitForSeconds(1);
            minusSign.SetActive(true);
            yield return new WaitForSeconds(1);
            num_1.SetActive(true); 
            zainahAn.SetTrigger("smile");           
        }

        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer1.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        cAnswer.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer2.SetActive(true);

    }

}
