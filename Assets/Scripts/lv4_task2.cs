using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class lv4_task2 : MonoBehaviour
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
    public GameObject zaeidcherry1;
    public GameObject zaeidcherry2;
    public GameObject zaeidcherry3;
    public GameObject zaeidcherry4;
     public GameObject zaeidcherry5;
    public GameObject zaeidcherry6;
    public GameObject zaeidcherry7;
    public GameObject zaeidcherry8;
     public GameObject zaeidcherry9;
    public GameObject zaeidcherry10;
    public GameObject plus;
    public GameObject No1;
    public GameObject No2;
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject button1 ;
    public GameObject button2 ;
    public GameObject button3 ;





 [System.Obsolete]
    void Start()
    {
    
    
      StartCoroutine(WaitBeforeShowpop());
      
    }

     private IEnumerator WaitBeforeShowpop()
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
            BasketZaeid.SetActive(true);
            yield return new WaitForSeconds(1);
            popup.Play();
            zainah.SetActive(true);
            yield return new WaitForSeconds(1);
             zaeidAn.SetTrigger("talk");
             taskQ.Play();
            yield return new WaitForSeconds((float)3.5);
            popup.Play();
            No1.SetActive(true);
            zaeidcherry1.SetActive(true);
            zaeidcherry2.SetActive(true);
            zaeidcherry3.SetActive(true);
            zaeidcherry4.SetActive(true);
            zaeidcherry5.SetActive(true);
            zaeidcherry6.SetActive(true);
            zaeidcherry7.SetActive(true);
            zaeidcherry8.SetActive(true);
            zaeidcherry9.SetActive(true);
            zaeidcherry10.SetActive(true);
            zaeidAn.SetTrigger("smile");
            zainahAn.SetTrigger("talk");
             yield return new WaitForSeconds(1);
             popup.Play();
             plus.SetActive(true);
             No2.SetActive(true);
            yield return new WaitForSeconds(2);
            zaeidAn.SetTrigger("talk");
            zainahAn.SetTrigger("smile");
            yield return new WaitForSeconds(2);
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
