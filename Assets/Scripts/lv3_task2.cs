using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class lv3_task2 : MonoBehaviour
{
   // public GameObject canva;
    public Animator zaeidAn;
    public Animator zainahAn;
    public GameObject zaeid;
    public GameObject zainah;
    public Animator candy_Zaeid1;
    public Animator candy_Zaeid2;
    public Animator candy_Zaeid3;
    public Animator candy_Zainah1;
    public Animator candy_Zainah2;
    public Animator candy_Zainah3;
    public GameObject candyZaeid1;
    public GameObject candyZaeid2;
    public GameObject candyZaeid3;
    public GameObject candyZainah1;
    public GameObject candyZainah2;
    public GameObject candyZainah3;
    public GameObject number1;
    public GameObject number3;
    public GameObject number1F;
    public GameObject number3F;
    public GameObject wAnswer1 ;
    public GameObject wAnswer2 ;
    public GameObject cAnswer ;
    public GameObject wAnswer1M ;
    public GameObject wAnswer2M ;
    public GameObject cAnswerM ;
    public GameObject back;
    public AudioSource click ;
    public AudioSource popUp ;
    public AudioSource ZaeidF ;
    public AudioSource ZaeidM ;
    public AudioSource ZainahF ;
    public AudioSource ZainahM ;
    

void Start()
    {
        zaeid.SetActive(false);
         StartCoroutine(WaitBeforeShowpop());
        
    }

     private IEnumerator WaitBeforeShowpop()
    {
 yield return new WaitForSeconds(1);
        popUp.Play();
        back.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        if(GetInformation.Getinfo.SelectedCharacter == "M" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {zaeid.SetActive(true);
        yield return new WaitForSeconds(1);
        zaeidAn.SetTrigger("talk");
        ZaeidM.Play();}
        else if (GetInformation.Getinfo.SelectedCharacter == "M" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {zaeid.SetActive(true);
        yield return new WaitForSeconds(1);
        zaeidAn.SetTrigger("talk");
        ZaeidF.Play();}
        else if (GetInformation.Getinfo.SelectedCharacter == "F" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {zainah.SetActive(true);
        yield return new WaitForSeconds(1);
        zainahAn.SetTrigger("talk");
        ZainahM.Play();}
        else 
        {zainah.SetActive(true);
        yield return new WaitForSeconds(1);
        zainahAn.SetTrigger("talk");
        ZainahF.Play();}

        if(GetInformation.Getinfo.SelectedCharacter == "M")
        {yield return new WaitForSeconds(1);
        candyZainah1.SetActive(true);
        candyZainah2.SetActive(true);
        candyZainah3.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        number3F.SetActive(true);
        yield return new WaitForSeconds(1);
        candyZaeid1.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        number1F.SetActive(true);
        yield return new WaitForSeconds(2);
        popUp.Play();
        cAnswerM.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer1M.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer2M.SetActive(true);
        zaeidAn.SetTrigger("smile");}

        else
        {yield return new WaitForSeconds(1);
        candyZainah1.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        number1.SetActive(true);
        yield return new WaitForSeconds(1);
        candyZaeid1.SetActive(true);
        candyZaeid2.SetActive(true);        
        candyZaeid3.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        number3.SetActive(true);
        yield return new WaitForSeconds(2);
        popUp.Play();
        cAnswer.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer2.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        wAnswer1.SetActive(true);
        zainahAn.SetTrigger("smile");}




}

}
