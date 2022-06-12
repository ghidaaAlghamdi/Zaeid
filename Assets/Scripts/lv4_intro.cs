using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class lv4_intro : MonoBehaviour
{
    //environment sounds
    public AudioSource introdM ;
    public AudioSource introdF ;
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
    public GameObject plus;
    public GameObject zaeid;
    public GameObject zainah;
    public Button YesButton ;
    public Button NoButton ;


    public lv4_task1 l4t1;


  public void PlayIntro()
    {
        StartCoroutine(this.WaitBeforeShowpop());

        l4t1 = GameObject.FindGameObjectWithTag("l4t1").GetComponent<lv4_task1>();

        YesButton.onClick.AddListener(YesButton_Click);
        NoButton.onClick.AddListener(NoButton_Click);
        
    }

    void YesButton_Click()
    {
        StartCoroutine(l4t1.WaitBeforeShowpop());
    }
    void NoButton_Click()
    {
        SceneManager.LoadScene("HomePage");
    }
    

     private IEnumerator WaitBeforeShowpop()
    {

        if (GetInformation.Getinfo.Gender== "ﻰﺜﻧﺃ")
        {

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
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            zaeidAn.SetTrigger("talk");
            introdF.Play();
            yield return new WaitForSeconds(5);
            zaeidAn.SetTrigger("smile");
            yield return new WaitForSeconds((float)0.5);
            zainahAn.SetTrigger("talk");
             yield return new WaitForSeconds((float)4.5);
            popup.Play();
            plus.SetActive(true);
            yield return new WaitForSeconds((float)0.5);
            zaeidAn.SetTrigger("talk");
            zainahAn.SetTrigger("smile");
            yield return new WaitForSeconds(5);
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds((float)2.5);
            zainahAn.SetTrigger("smile");
            zaeidAn.SetTrigger("smile");
            yield return new WaitForSeconds(1);
             popup.Play();
            YesButton.gameObject.SetActive(true);
            yield return new WaitForSeconds((float)0.5);
             popup.Play();
            NoButton.gameObject.SetActive(true);

         }
         
          else if(GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {

            yield return new WaitForSeconds(3);
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
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            zaeidAn.SetTrigger("talk");
            introdM.Play();
            yield return new WaitForSeconds(5);
            zaeidAn.SetTrigger("smile");
            yield return new WaitForSeconds((float)0.5);
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds(3);
            popup.Play();
            plus.SetActive(true);
            yield return new WaitForSeconds(2);
            zaeidAn.SetTrigger("talk");
            zainahAn.SetTrigger("smile");
            yield return new WaitForSeconds(5);
            zainahAn.SetTrigger("talk");
            zaeidAn.SetTrigger("talk");
            yield return new WaitForSeconds((float)2.5);
            zainahAn.SetTrigger("smile");
            zaeidAn.SetTrigger("smile");
            zaeid.SetActive(true);
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
            popup.Play();
            YesButton.gameObject.SetActive(true);
            yield return new WaitForSeconds((float)0.5);
            popup.Play();
           NoButton.gameObject.SetActive(true);
          }

}
  
}
