using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class lv4_task3 : MonoBehaviour
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
    public GameObject zaeidcherry1;
    public GameObject zaeidcherry2;
    public GameObject zaeidcherry3;
    public GameObject zainahcherry1;
     public GameObject zainahcherry2;
    public GameObject zainahcherry3;
    public GameObject zainahcherry4;
    public GameObject zainahcherry5;
     public GameObject zainahcherry6;
      public GameObject plus;
    public GameObject No1;
    public GameObject No2;
     public GameObject No1_2;
    public GameObject No2_2;
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject button1 ;
    public GameObject button2 ;
    public GameObject button3 ;

     //lv4_task3_part2 
   int clickNo=0;
   public AudioSource task_part2;
   public AudioSource task_part3;
   public checkAnswers checkAnswers;

   






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
            BasketZainah.SetActive(true);
           yield return new WaitForSeconds(1);
            zaeidAn.SetTrigger("talk");
            taskQ.Play();
            yield return new WaitForSeconds((float)1.5);
            popup.Play();
            No1.SetActive(true);
            zaeidcherry1.SetActive(true);
            zaeidcherry2.SetActive(true);
            zaeidcherry3.SetActive(true);
            yield return new WaitForSeconds(1);
            zaeidAn.SetTrigger("smile");
            zainahAn.SetTrigger("talk");
            plus.SetActive(true);
            yield return new WaitForSeconds(1);
            popup.Play();
            No2.SetActive(true);
            zainahcherry1.SetActive(true);
            zainahcherry2.SetActive(true);
            zainahcherry3.SetActive(true);
            zainahcherry4.SetActive(true);
            zainahcherry5.SetActive(true);
            zainahcherry6.SetActive(true);
            yield return new WaitForSeconds(3);
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

public void lv4Click(){

        clickNo++;
        click.Play();
        
        if(clickNo==1){
           plus.SetActive(false);
           No1.SetActive(false);
           No2.SetActive(false);
            button1.SetActive(false);
            button2.SetActive(false);
            button3.SetActive(false);
            zainahAn.SetTrigger("talk");
            task_part2.Play();
           StartCoroutine((WaitBeforeShowButton()));

        }else {

              checkAnswers.chooseRightAnswer();  
        }


    }

    private IEnumerator WaitBeforeShowButton()
    {
        yield return new WaitForSeconds(9);
        popup.Play();
        No1_2.SetActive(true);
        yield return new WaitForSeconds(2);
        popup.Play();
        plus.SetActive(true);
        zainahAn.SetTrigger("smile");
        zaeidAn.SetTrigger("talk");
        task_part3.Play();
        yield return new WaitForSeconds(1);
        popup.Play();
        No2_2.SetActive(true);
        yield return new WaitForSeconds(4);
         zaeidAn.SetTrigger("smile");
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
