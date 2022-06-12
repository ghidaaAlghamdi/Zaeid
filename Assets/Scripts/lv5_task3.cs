using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lv5_task3 : MonoBehaviour
{
   

    public Animator zaeidAn;
    public Animator zainahAn;
    public Animator donut1;
    public Animator donut2;
    public Animator donut3;
    public Animator donut4;

    public GameObject zaeid;
    public GameObject zainah;
    public GameObject cashier;
    public GameObject customer;
    public GameObject sugar;
    public GameObject cinnamon;
    public GameObject chocolate;
    public GameObject cherry;
    public GameObject num_3;
    public GameObject minusSign;
    public GameObject num_0;

    public GameObject wAnswer1;
    public GameObject cAnswer;
    public GameObject wAnswer2;

    public AudioSource click;
    public AudioSource popUp;
    public AudioSource ZaeidT3;
    public AudioSource ZainahT3;


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
            ZaeidT3.Play();
            yield return new WaitForSeconds(4);
            sugar.SetActive(true);
            yield return new WaitForSeconds(1);
            cinnamon.SetActive(true);
            yield return new WaitForSeconds(1);
            chocolate.SetActive(true);
            yield return new WaitForSeconds(3);
            cherry.SetActive(true);      
            yield return new WaitForSeconds(4);
            num_3.SetActive(true);
            yield return new WaitForSeconds(1);
            minusSign.SetActive(true);
            yield return new WaitForSeconds(1);
            num_0.SetActive(true);      
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
            ZainahT3.Play();
            yield return new WaitForSeconds(4);
            sugar.SetActive(true);
            yield return new WaitForSeconds(1);
            cinnamon.SetActive(true);
            yield return new WaitForSeconds(1);
            chocolate.SetActive(true);
            yield return new WaitForSeconds(3);
            cherry.SetActive(true);          
            yield return new WaitForSeconds(2);
            num_3.SetActive(true);
            yield return new WaitForSeconds(1);
            minusSign.SetActive(true);
            yield return new WaitForSeconds(1);
            num_0.SetActive(true); 
            zainahAn.SetTrigger("smile");
        }
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer1.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer2.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        cAnswer.SetActive(true);

    }

}
