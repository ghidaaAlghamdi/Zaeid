using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lv5_task2 : MonoBehaviour
{
   // public GameObject quit;
     
    public Animator zaeidAn;
    public Animator zainahAn;
    public Animator shopCakes;
    public Animator custOrders;

    public GameObject zaeid;
    public GameObject zainah;
    public GameObject cashier;
    public GameObject customer;
    public GameObject shopCake;
    public GameObject custOrder;
    public GameObject num3_1;
    public GameObject minusSign;
    public GameObject num3_2;

    public GameObject wAnswer1;
    public GameObject cAnswer;
    public GameObject wAnswer2;   

    public AudioSource click;
    public AudioSource popUp;
    public AudioSource ZaeidT2;
    public AudioSource ZainahT2;


    void Start()
    {
        zaeid.SetActive(false);
        StartCoroutine(WaitBeforeShowpop());    
    }

    private IEnumerator WaitBeforeShowpop()
    {
        
      
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
            ZaeidT2.Play();
            yield return new WaitForSeconds(1);
            shopCake.SetActive(true);
            yield return new WaitForSeconds(2);
            custOrder.SetActive(true);
            yield return new WaitForSeconds(3);
            num3_1.SetActive(true);
            yield return new WaitForSeconds(1);
            minusSign.SetActive(true);
            yield return new WaitForSeconds(1);
            num3_2.SetActive(true);   
            zaeidAn.SetTrigger("smile");
      
        }
      
        else //if (selectedCharacter=="F")
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
            ZainahT2.Play();
            yield return new WaitForSeconds(1);
            shopCake.SetActive(true);
            yield return new WaitForSeconds(3);
            custOrder.SetActive(true);
           
            yield return new WaitForSeconds(2);
            num3_1.SetActive(true);
            yield return new WaitForSeconds(1);
            minusSign.SetActive(true);
            yield return new WaitForSeconds(1);
            num3_2.SetActive(true);   
            zainahAn.SetTrigger("smile");
         
        }
        yield return new WaitForSeconds(1);
        popUp.Play();
        cAnswer.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer1.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer2.SetActive(true);

    }

}
