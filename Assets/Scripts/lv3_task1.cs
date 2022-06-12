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
public class lv3_task1 : MonoBehaviour
{
   //public GameObject canva;
    public Animator zaeidAn;
    public Animator zainahAn;
    public Animator candy_Zaeid1;
    public Animator candy_Zaeid2;
    public Animator candy_Zainah1;
    public Animator candy_Zainah2;
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject candyZaeid1;
    public GameObject candyZaeid2;
    public GameObject candyZainah1;
    public GameObject candyZainah2;
    public GameObject number2_1;
    public GameObject number2_2;
    public GameObject wAnswer1 ;
    public GameObject wAnswer2 ;
    public GameObject cAnswer ;
    public GameObject back;
    public AudioSource click ;
    public AudioSource popUp ;
    public AudioSource ZaeidF ;
    public AudioSource ZaeidM ;
    public AudioSource ZainahF ;
    public AudioSource ZainahM ;


    public int Scores;
    public int sc;

    public l3intro Intro;
    public GameObject IntroEnv;
    public GameObject IntroCnvas;



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

        Intro = GameObject.FindGameObjectWithTag("Intro3").GetComponent<l3intro>();

        if (sc == 60)
        {
            Intro.PlayIntro();
        }
        else if (sc > 60)
        {
            StartCoroutine(WaitBeforeShowpop());
        }
    }

    public IEnumerator WaitBeforeShowpop()
    {
        IntroEnv.SetActive(false);
        IntroCnvas.SetActive(false);

        yield return new WaitForSeconds(1);
        popUp.Play();
        back.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();

        if (GetInformation.Getinfo.SelectedCharacter == "M" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {
            zaeid.SetActive(true);
            yield return new WaitForSeconds(1);
            zaeidAn.SetTrigger("talk");
            ZaeidM.Play();
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "M" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            zaeid.SetActive(true);
            yield return new WaitForSeconds(1);
            zaeidAn.SetTrigger("talk");
            ZaeidF.Play();
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "F" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            zainahAn.SetTrigger("talk");
            ZainahM.Play();
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "F" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            zainahAn.SetTrigger("talk");
            ZainahF.Play();
        }


        yield return new WaitForSeconds(1);
        candyZainah1.SetActive(true);
        candyZainah2.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        number2_2.SetActive(true);
        yield return new WaitForSeconds(1);
        candyZaeid1.SetActive(true);
        candyZaeid2.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        number2_1.SetActive(true);
        yield return new WaitForSeconds(3);
        popUp.Play();
        wAnswer1.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer2.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        cAnswer.SetActive(true);
        if(GetInformation.Getinfo.SelectedCharacter == "M")
        {zaeidAn.SetTrigger("smile");}
        else
        {zainahAn.SetTrigger("smile");}

}

}
