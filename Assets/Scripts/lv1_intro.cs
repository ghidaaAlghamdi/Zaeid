using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class lv1_intro : MonoBehaviour
{
    //environment sounds
    public AudioSource zaeidintrodM ;
    public AudioSource zaeidintrodF ;
    public AudioSource zainahintrodM ;
    public AudioSource zainahintrodF ;
    public AudioSource click ;
    public AudioSource popUp;

    //environment animators
    public Animator zaeidAn;
    public Animator zainahAn;

    //all environment gameobjects
    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;
    public GameObject school;
    public GameObject bag;
    public GameObject zaeid;
    public GameObject zainah;
    public Button YesButton;
    public Button NoButton;


   
    

//public GameObject l4t1;
    public lv1_task1 l1t1;



    public void PlayIntro()
    {
        StartCoroutine(this.WaitBeforeShowpop());

        l1t1 = GameObject.FindGameObjectWithTag("l1t1").GetComponent<lv1_task1>();

        YesButton.onClick.AddListener(YesButton_Click);
        NoButton.onClick.AddListener(NoButton_Click);
      
    }

      [System.Obsolete]
    void YesButton_Click()
    {
        StartCoroutine(l1t1.WaitBeforeShowpop());
    }
    void NoButton_Click()
    {
        SceneManager.LoadScene("HomePage");
    }

     private IEnumerator WaitBeforeShowpop()
    {
        if(GetInformation.Getinfo.SelectedCharacter=="F"){

            if(GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ"){

            yield return new WaitForSeconds(3);
            popUp.Play();
            tree1.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree2.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree3.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree4.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            school.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            zainah.SetActive(true);
            bag.SetActive(true);
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            zainahintrodF.Play();
            yield return new WaitForSeconds(11);
            zainahAn.SetTrigger("smile");
            zainah.SetActive(true);
            //canva.SetActive(true);
            yield return new WaitForSeconds(1);
            //canva.SetActive(true);
            popUp.Play();
            YesButton.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
             NoButton.gameObject.SetActive(true);

            }else if(GetInformation.Getinfo.Gender == "ﺮﻛﺫ"){

            yield return new WaitForSeconds(3);
            popUp.Play();
            tree1.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree2.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree3.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree4.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            school.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            zainah.SetActive(true);
            bag.SetActive(true);
            zainahAn.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            zainahintrodM.Play();
            yield return new WaitForSeconds(11);
            zainahAn.SetTrigger("smile");
            zainah.SetActive(true);
            //canva.SetActive(true);
            yield return new WaitForSeconds(1);
            //canva.SetActive(true);
            popUp.Play();
            YesButton.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
             NoButton.gameObject.SetActive(true);

            }

        }else if (GetInformation.Getinfo.SelectedCharacter =="M"){

          if(GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ"){

            yield return new WaitForSeconds(3);
            popUp.Play();
            tree1.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree2.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree3.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree4.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            school.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            zaeid.SetActive(true);
            bag.SetActive(true);
            zaeidAn.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            zaeidintrodF.Play();
            yield return new WaitForSeconds(12);
            zaeidAn.SetTrigger("smile");
            zaeid.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
             YesButton.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            NoButton.gameObject.SetActive(true);

          }else if(GetInformation.Getinfo.Gender == "ﺮﻛﺫ"){

             yield return new WaitForSeconds(3);
             popUp.Play();
            tree1.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree2.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree3.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            tree4.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            school.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            zaeid.SetActive(true);
            bag.SetActive(true);
            zaeidAn.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            zaeidintrodM.Play();
            yield return new WaitForSeconds(12);
            zaeidAn.SetTrigger("smile");
            zaeid.SetActive(true);
            //canva.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            //canva.SetActive(true);
             YesButton.gameObject.SetActive(true);
            yield return new WaitForSeconds(1);
            popUp.Play();
            NoButton.gameObject.SetActive(true);

          }

        }

}


}
