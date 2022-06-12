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


public class lv4_task1 : MonoBehaviour
{
    //environment sounds
    public AudioSource taskQ;
    public AudioSource click ;
    public AudioSource popup;

    //environment animators
    public Animator zaeidAn;
    public Animator zainahAn;

    //all environment gameobjects
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject tree5;
    public GameObject BasketZaeid;
    public GameObject BasketZainah;
    public GameObject zainahcherry1;
    public GameObject zainahcherry2;
    public GameObject zainahcherry3;
    public GameObject zaeidcherry1;
    public GameObject zaeidcherry2;
    public GameObject zaeidcherry3;
    public GameObject zaeidcherry4;
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject plus;
    public GameObject No1;
    public GameObject No2;
    public GameObject button1 ;
    public GameObject button2 ;
    public GameObject button3 ;

    public lv4_intro Intro;
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

        Intro = GameObject.FindGameObjectWithTag("intro4").GetComponent<lv4_intro>();

        if (sc == 90)
        {
            Intro.PlayIntro();
        }
        else if (sc > 90)
        {
            StartCoroutine(WaitBeforeShowpop());
        }
    }


     public IEnumerator WaitBeforeShowpop()
    {

        IntroEnv.SetActive(false);
        IntroCnvas.SetActive(false);
        yield return new WaitForSeconds(1);
        yield return new WaitForSeconds(1);
        popup.Play();
        tree1.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        tree2.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        tree3.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        tree4.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        tree5.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        zaeid.SetActive(true);
        BasketZaeid.SetActive(true);
       yield return new WaitForSeconds(1);
        popup.Play();
        zainah.SetActive(true);
        BasketZainah.SetActive(true);
        yield return new WaitForSeconds(1);
        zaeidAn.SetTrigger("talk");
        yield return new WaitForSeconds(1);
        taskQ.Play();
        popup.Play();
        No1.SetActive(true);
        zaeidcherry1.SetActive(true);
        zaeidcherry2.SetActive(true);
        zaeidcherry3.SetActive(true);
        zaeidcherry4.SetActive(true);
        yield return new WaitForSeconds(1);
        plus.SetActive(true);
        yield return new WaitForSeconds(1);
        zaeidAn.SetTrigger("smile");
        zainahAn.SetTrigger("talk");
        popup.Play();
        No2.SetActive(true);
        zainahcherry1.SetActive(true);
        zainahcherry2.SetActive(true);
        zainahcherry3.SetActive(true);
        yield return new WaitForSeconds(4);
        zainahAn.SetTrigger("smile");
        zaeidAn.SetTrigger("smile");
        zaeid.SetActive(true);
        zainah.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        button1.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        button2.SetActive(true);
        yield return new WaitForSeconds(1);
        popup.Play();
        button3.SetActive(true);

    }
  
}
