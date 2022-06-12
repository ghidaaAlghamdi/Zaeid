using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Networking;

public class lv1_task2 : MonoBehaviour{

    //environment sounds
    public AudioSource zaeidquestion1 ;
    public AudioSource zainahquestion1 ;
    public AudioSource click ;
    public AudioSource popUp;

    //environment animators
    public Animator zaeidAn;
    public Animator zainahAn;

    //environment gameObjects
    public GameObject table;
    public GameObject zaeid;
    public GameObject zainah;
    public GameObject b1;
    public GameObject b2;
    public GameObject b3;
    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject button1 ;
    public GameObject button2 ;
    public GameObject button3 ;
   
  
   
 


    //Start is called before the first frame update
    [System.Obsolete]
    void Start()
    {
       
       zainah.SetActive(false);
       zaeid.SetActive(false);
      StartCoroutine(WaitBeforeShowpop());
        
    }

     private IEnumerator WaitBeforeShowpop()
    {
        if (GetInformation.Getinfo.SelectedCharacter=="F"){

         yield return new WaitForSeconds(3);
         popUp.Play();
         zainah.SetActive(true);
         zainahAn.SetTrigger("talk");
         yield return new WaitForSeconds(1);
         popUp.Play();
         table.SetActive(true);
         zainahquestion1.Play();
         yield return new WaitForSeconds(6);
         popUp.Play();
         m1.SetActive(true);
         m2.SetActive(true);
         m3.SetActive(true);
         yield return new WaitForSeconds(1);
         popUp.Play();
         b1.SetActive(true);
         b2.SetActive(true);
         b3.SetActive(true);
         yield return new WaitForSeconds(6);
         zainahAn.SetTrigger("smile");
         zainah.SetActive(true);
         yield return new WaitForSeconds(2);
           //canva.SetActive(true);
           popUp.Play();
         button1.SetActive(true);
         yield return new WaitForSeconds(1);
         popUp.Play();
         button2.SetActive(true);
         yield return new WaitForSeconds(1);
         popUp.Play();
         button3.SetActive(true);

        }if(GetInformation.Getinfo.SelectedCharacter=="M"){

         yield return new WaitForSeconds(3);
         popUp.Play();
         zaeid.SetActive(true);
         zaeidAn.SetTrigger("talk");
         yield return new WaitForSeconds(1);
         popUp.Play();
         table.SetActive(true);
         zaeidquestion1.Play();
         yield return new WaitForSeconds(6);
         popUp.Play();
         m1.SetActive(true);
         m2.SetActive(true);
         m3.SetActive(true);
        yield return new WaitForSeconds(1);
        popUp.Play();
         b1.SetActive(true);
         b2.SetActive(true);
         b3.SetActive(true);
         yield return new WaitForSeconds(7);
         zaeidAn.SetTrigger("smile");
         zaeid.SetActive(true);
         yield return new WaitForSeconds(2);
         popUp.Play();
         button1.SetActive(true);
         yield return new WaitForSeconds(1);
         popUp.Play();
         button2.SetActive(true);
         yield return new WaitForSeconds(1);
         popUp.Play();
         button3.SetActive(true);

        }

    }




}