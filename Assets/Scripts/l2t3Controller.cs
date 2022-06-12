using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class l2t3Controller : MonoBehaviour
{
    public Animator ZaeidAnim;
    public Animator ZainaAnim;
    public GameObject Zaeid;
    public GameObject Zaina;
    public GameObject Num1_1;
    public GameObject Num2_1;
    public GameObject Num3_1;
    public GameObject Num1_2;
    public GameObject Num2_2;
    public GameObject Num3_2;
    public AudioSource Num1_1Zaeid_M;
    public AudioSource Num2_1Zaeid_M;
    public AudioSource Num3_1Zaeid_M;
    public AudioSource Num1_2Zaeid_M;
    public AudioSource Num2_2Zaeid_M;
    public AudioSource Num3_2Zaeid_M;
    public AudioSource Num1_1Zaeid_F;
    public AudioSource Num2_1Zaeid_F;
    public AudioSource Num3_1Zaeid_F;
    public AudioSource Num1_2Zaeid_F;
    public AudioSource Num2_2Zaeid_F;
    public AudioSource Num3_2Zaeid_F;
    public AudioSource QuestionZaeid_M;
    public AudioSource QuestionZaeid_F;
    public AudioSource Num1_1Zaina_M;
    public AudioSource Num2_1Zaina_M;
    public AudioSource Num3_1Zaina_M;
    public AudioSource Num1_2Zaina_M;
    public AudioSource Num2_2Zaina_M;
    public AudioSource Num3_2Zaina_M;
    public AudioSource Num1_1Zaina_F;
    public AudioSource Num2_1Zaina_F;
    public AudioSource Num3_1Zaina_F;
    public AudioSource Num1_2Zaina_F;
    public AudioSource Num2_2Zaina_F;
    public AudioSource Num3_2Zaina_F;
    public AudioSource QuestionZaina_M;
    public AudioSource QuestionZaina_F;
    public AudioSource NumPopup;
    public Button B1;
    public Button B2;
    public Button B3;


    void Start()
    {
        StartCoroutine(WaitBeforeShowpop());
    }

    public IEnumerator WaitBeforeShowpop()
    {
        if (GetInformation.Getinfo.SelectedCharacter == "M" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {
            yield return new WaitForSeconds(2);
            Zaeid.SetActive(true);
            //ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1Zaeid_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaeid_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_1Zaeid_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");

            NumPopup.Play();
            Num1_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num2_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num3_1.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_2.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_2Zaeid_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            NumPopup.Play();
            Num1_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num2_2.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_2Zaeid_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            NumPopup.Play();
            Num2_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num3_2.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_2Zaeid_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            NumPopup.Play();
            Num3_2.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            QuestionZaeid_M.Play();
            yield return new WaitForSeconds(2);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaeid_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");

            B1.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            NumPopup.Play();
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "M" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            yield return new WaitForSeconds(2);
            Zaeid.SetActive(true);
            //ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1Zaeid_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaeid_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_1Zaeid_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");

            NumPopup.Play();
            Num1_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num2_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num3_1.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_2.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_2Zaeid_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            NumPopup.Play();
            Num1_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num2_2.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_2Zaeid_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            NumPopup.Play();
            Num2_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num3_2.SetActive(true);
            NumPopup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_2Zaeid_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            NumPopup.Play();
            Num3_2.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            QuestionZaeid_F.Play();
            yield return new WaitForSeconds(2);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaeid_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");

            B1.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            NumPopup.Play();
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "F" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {
            yield return new WaitForSeconds(2);
            Zaina.SetActive(true);
            //ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1Zaina_M.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaina_M.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_1Zaina_M.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");

            NumPopup.Play();
            Num1_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num2_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num3_1.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_2.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_2Zaina_M.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            NumPopup.Play();
            Num1_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num2_2.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_2Zaina_M.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            NumPopup.Play();
            Num2_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num3_2.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_2Zaina_M.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            NumPopup.Play();
            Num3_2.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            QuestionZaina_M.Play();
            yield return new WaitForSeconds(2);
            ZainaAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaina_M.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");

            B1.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            NumPopup.Play();
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "F" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            yield return new WaitForSeconds(2);
            Zaina.SetActive(true);
            //ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_1Zaina_F.Play();
            yield return new WaitForSeconds(1);
            ZaeidAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaina_F.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_1Zaina_F.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");

            NumPopup.Play();
            Num1_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num2_1.SetActive(false);
            yield return new WaitForSeconds(1);
            NumPopup.Play();
            Num3_1.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_2.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num1_2Zaina_F.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            NumPopup.Play();
            Num1_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num2_2.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_2Zaina_F.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            NumPopup.Play();
            Num2_2.SetActive(false);
            yield return new WaitForSeconds(1);
            Num3_2.SetActive(true);
            NumPopup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num3_2Zaina_F.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");
            NumPopup.Play();
            Num3_2.SetActive(false);
            yield return new WaitForSeconds(1);

            Num1_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num2_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            Num3_1.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            QuestionZaina_F.Play();
            yield return new WaitForSeconds(2);
            ZainaAnim.SetTrigger("smile");
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Num2_1Zaina_F.Play();
            yield return new WaitForSeconds(1);
            ZainaAnim.SetTrigger("smile");

            B1.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            NumPopup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            NumPopup.Play();
        }


    }
}
