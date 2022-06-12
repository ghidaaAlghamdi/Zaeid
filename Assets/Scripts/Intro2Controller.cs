using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class Intro2Controller : MonoBehaviour
{
    public Animator ZaeidAnim;
    public Animator ZainaAnim;
    public GameObject Zaeid;
    public GameObject Zaina;
    public GameObject House;
    public GameObject Tree1;
    public GameObject Tree2;
    public GameObject Tree3;
    public GameObject Cloud1;
    public GameObject Cloud2;
    public AudioSource IntroZaeid_M;
    public AudioSource IntroZaeid_F;
    public AudioSource IntroZaina_M;
    public AudioSource IntroZaina_F;
    public Button YesButton;
    public Button NoButton;
    public AudioSource Popup;


    public l2t1Controller l2t1;


    public void PlayIntro()
    {
        StartCoroutine(this.WaitBeforeShowpop());

        l2t1 = GameObject.FindGameObjectWithTag("l2t1").GetComponent<l2t1Controller>();

        YesButton.onClick.AddListener(YesButton_Click);
        NoButton.onClick.AddListener(NoButton_Click);
        
    }

    void YesButton_Click()
    {
        StartCoroutine(l2t1.WaitBeforeShowpop());
    }
    void NoButton_Click()
    {
        SceneManager.LoadScene("HomePage");
    }

    public IEnumerator WaitBeforeShowpop()
    {
        if(GetInformation.Getinfo.SelectedCharacter == "M")
        {
            yield return new WaitForSeconds(3);
            House.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Cloud1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Cloud2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Tree1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Tree2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Tree3.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Zaeid.SetActive(true);
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);

            if(GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
            {
                IntroZaeid_M.Play();
                yield return new WaitForSeconds(9);
                ZaeidAnim.SetTrigger("smile");
                yield return new WaitForSeconds(1);
                YesButton.gameObject.SetActive(true);
                Popup.Play();
                yield return new WaitForSeconds(1);
                NoButton.gameObject.SetActive(true);
                Popup.Play();
            }
            else 
            {
                IntroZaeid_F.Play();
                yield return new WaitForSeconds(9);
                ZaeidAnim.SetTrigger("smile");
                yield return new WaitForSeconds(1);
                YesButton.gameObject.SetActive(true);
                Popup.Play();
                yield return new WaitForSeconds(1);
                NoButton.gameObject.SetActive(true);
                Popup.Play();
            }

        }

        else if(GetInformation.Getinfo.SelectedCharacter == "F")
        {
            yield return new WaitForSeconds(3);
            House.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Cloud1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Cloud2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Tree1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Tree2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Tree3.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Zaina.SetActive(true);
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);

            if(GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
            {
                IntroZaina_M.Play();
                yield return new WaitForSeconds(9);
                ZainaAnim.SetTrigger("smile");
                yield return new WaitForSeconds(1);
                YesButton.gameObject.SetActive(true);
                Popup.Play();
                yield return new WaitForSeconds(1);
                NoButton.gameObject.SetActive(true);
                Popup.Play();
            }
            else
            {
                IntroZaina_F.Play();
                yield return new WaitForSeconds(9);
                ZainaAnim.SetTrigger("smile");
                yield return new WaitForSeconds(1);
                YesButton.gameObject.SetActive(true);
                Popup.Play();
                yield return new WaitForSeconds(1);
                NoButton.gameObject.SetActive(true);
                Popup.Play();
            }

        }

    }
}
