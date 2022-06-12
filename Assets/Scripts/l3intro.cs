using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class l3intro : MonoBehaviour
{
    public GameObject canvas;
    public AudioSource click ;
    public Animator zaeidAn;
    public Animator zainahAn;
    public GameObject chair1;
    public GameObject chair2;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject zaeid;
    public GameObject zainah;
    public Button button1 ;
    public Button button2 ;

    public GameObject candyZaeid1;
    public GameObject candyZaeid2;
    public GameObject candyZainah1;
    public GameObject candyZainah2;
    public GameObject candyZainah3;


    public Animator candy_Zaeid1;
    public Animator candy_Zaeid2;
    public Animator candy_Zainah1;
    public Animator candy_Zainah2;
    public Animator candy_Zainah3;

    public AudioSource popUp ;
    public AudioSource introM ;
    public AudioSource introF ;

    public lv3_task1 l3t1;



    public void PlayIntro()
    {
        Debug.Log("im in intro3");
        StartCoroutine(this.WaitBeforeShowpop());

        l3t1 = GameObject.FindGameObjectWithTag("l3t1").GetComponent<lv3_task1>();

        button1.onClick.AddListener(YesButton_Click);
        button2.onClick.AddListener(NoButton_Click);

    }

    void YesButton_Click()
    {
        StartCoroutine(l3t1.WaitBeforeShowpop());
    }
    void NoButton_Click()
    {
        SceneManager.LoadScene("HomePage");
    }

    private IEnumerator WaitBeforeShowpop()
    {
        Debug.Log("i got in 3");
            yield return new WaitForSeconds(3);
            popUp.Play();
            chair1.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            chair2.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree1.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree2.SetActive(true);

            yield return new WaitForSeconds(1);
            popUp.Play();
            zaeid.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            zainah.SetActive(true);

        if (GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {
            introM.Play();
        }
        else
        {
            introF.Play();
        }
            
            
            
            zaeidAn.SetTrigger("talk");
            yield return new WaitForSeconds(2);
            zaeidAn.SetTrigger("smile");
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            zainahAn.SetTrigger("smile");
            zaeidAn.SetTrigger("talk");
            yield return new WaitForSeconds(2);
            zaeidAn.SetTrigger("smile");
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds(4);
            zainahAn.SetTrigger("smile");
            zaeidAn.SetTrigger("talk");
            yield return new WaitForSeconds(2);
            popUp.Play();
            candyZaeid1.SetActive(true);
            candyZaeid2.SetActive(true);
            yield return new WaitForSeconds(2);
            zaeidAn.SetTrigger("smile");
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            popUp.Play();
            candyZainah1.SetActive(true);
            candyZainah2.SetActive(true);
            candyZainah3.SetActive(true);
            yield return new WaitForSeconds(5);
            zainahAn.SetTrigger("smile");
            zaeidAn.SetTrigger("talk");
            yield return new WaitForSeconds(4);
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds(4);
            zainahAn.SetTrigger("smile");
            zaeidAn.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            popUp.Play();
            button1.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            button2.gameObject.SetActive(true);
}
}
