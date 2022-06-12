using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class l5intro : MonoBehaviour
{
    public GameObject canvas;
    public AudioSource click ;
    
    public GameObject shop;
    public GameObject cloud1;
    public GameObject cloud2;
    public GameObject tree1;
    public GameObject tree2;
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject minus;
   // public GameObject quit;
    public Button YesButton;
    public Button NoButton;
    
    public Animator zaeidAn;
    public Animator zainahAn;
    public Animator minusAn;

    public AudioSource popUp;
    public AudioSource zaeidIntroM;
    public AudioSource zaeidIntroF;
    public AudioSource zainahIntroM;
    public AudioSource zainahIntroF;

    public string userGender="F";
    public string selectedCharacter="M";


 public lv5_task1 l5t1;


     public void PlayIntro()
    {
        StartCoroutine(this.WaitBeforeShowpop());

        l5t1 = GameObject.FindGameObjectWithTag("l5t1").GetComponent<lv5_task1>();

        YesButton.onClick.AddListener(YesButton_Click);
        NoButton.onClick.AddListener(NoButton_Click);
        
    }

    void YesButton_Click()
    {
        StartCoroutine(l5t1.WaitBeforeShowpop());
    }
    void NoButton_Click()
    {
        SceneManager.LoadScene("HomePage");
    }
    private IEnumerator WaitBeforeShowpop()
    {
        yield return new WaitForSeconds(3);
        popUp.Play();
      //  quit.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        shop.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        cloud1.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        cloud2.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        tree1.SetActive(true);
        yield return new WaitForSeconds(1);
       popUp.Play();
        tree2.SetActive(true);
        if (GetInformation.Getinfo.SelectedCharacter=="M"){
            yield return new WaitForSeconds(1);
           // popUp.Play();
            zaeid.SetActive(true);
            zaeidAn.SetTrigger("talk");
            zaeidAn.SetTrigger("smile");
            if(GetInformation.Getinfo.Gender == "ﺮﻛﺫ"){
                zaeidIntroM.Play();
                yield return new WaitForSeconds(6);
                minus.SetActive(true);
                // yield return new WaitForSeconds(3);
                // zaeidAn.Play("smile");
            }
            else{
                zaeidIntroF.Play();
                yield return new WaitForSeconds(6);
                minus.SetActive(true);
                zaeidAn.SetTrigger("smile");
                // yield return new WaitForSeconds(2);
                // zaeidAn.Play("smile");
                }
            }
        else if (GetInformation.Getinfo.SelectedCharacter=="F"){
            yield return new WaitForSeconds(1);
            popUp.Play();
            zainah.SetActive(true);
            zainahAn.SetTrigger("talk");
            if(GetInformation.Getinfo.Gender == "ﺮﻛﺫ"){
                zainahIntroM.Play();
            }else{
                zainahIntroF.Play();}
            yield return new WaitForSeconds(6);
            minus.SetActive(true);
            zainahAn.SetTrigger("smile");

            //yield return new WaitForSeconds(3);

        }            
        yield return new WaitForSeconds(1);
        popUp.Play();
        YesButton.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
        NoButton.gameObject.SetActive(true);
    }
}
