using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class l2t2Controller : MonoBehaviour
{
    public Animator ZaeidAnim;
    public Animator ZainaAnim;
    public GameObject Zaeid;
    public GameObject Zaina;
    public GameObject Table;
    public GameObject Plate1;
    public GameObject Plate2;
    public GameObject Plate3;
    public Animator Plate1Anim;
    public Animator Plate2Anim;
    public Animator Plate3Anim;
    public AudioSource Question1_Zaeid_M;
    public AudioSource Question2_Zaeid_M;
    public AudioSource Question1_Zaeid_F;
    public AudioSource Question2_Zaeid_F;
    public AudioSource Question1_Zaina_M;
    public AudioSource Question2_Zaina_M;
    public AudioSource Question1_Zaina_F;
    public AudioSource Question2_Zaina_F;
    public AudioSource Num1_Zaeid;
    public AudioSource Num2_Zaeid;
    public AudioSource Num3_Zaeid;
    public AudioSource Num1_Zaina;
    public AudioSource Num2_Zaina;
    public AudioSource Num3_Zaina;
    public AudioSource Popup;
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
            Popup.Play();
            yield return new WaitForSeconds(1);
            Table.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate3.SetActive(true);
            Popup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Question1_Zaeid_M.Play();
            yield return new WaitForSeconds(10);
            Question2_Zaeid_M.Play();
            yield return new WaitForSeconds(3);
            Plate3Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num1_Zaeid.Play();
            yield return new WaitForSeconds(1);
            Plate2Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num2_Zaeid.Play();
            yield return new WaitForSeconds(1);
            Plate1Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num3_Zaeid.Play();
            yield return new WaitForSeconds(1);
            B1.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            Popup.Play();
            ZaeidAnim.SetTrigger("smile");
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "M" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            yield return new WaitForSeconds(2);
            Zaeid.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Table.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate3.SetActive(true);
            Popup.Play();
            ZaeidAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Question1_Zaeid_F.Play();
            yield return new WaitForSeconds(10);
            Question2_Zaeid_F.Play();
            yield return new WaitForSeconds(3);
            Plate3Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num1_Zaeid.Play();
            yield return new WaitForSeconds(1);
            Plate2Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num2_Zaeid.Play();
            yield return new WaitForSeconds(1);
            Plate1Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num3_Zaeid.Play();
            yield return new WaitForSeconds(1);
            B1.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            Popup.Play();
            ZaeidAnim.SetTrigger("smile");

        }

        else if (GetInformation.Getinfo.SelectedCharacter == "F" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {
            yield return new WaitForSeconds(2);
            Zaina.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Table.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate3.SetActive(true);
            Popup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Question1_Zaina_M.Play();
            yield return new WaitForSeconds(10);
            Question2_Zaina_M.Play();
            yield return new WaitForSeconds(3);
            Plate3Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num1_Zaina.Play();
            yield return new WaitForSeconds(1);
            Plate2Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num2_Zaina.Play();
            yield return new WaitForSeconds(1);
            Plate1Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num3_Zaina.Play();
            yield return new WaitForSeconds(1);
            B1.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            Popup.Play();
            ZainaAnim.SetTrigger("smile");

        }

        else if (GetInformation.Getinfo.SelectedCharacter == "F" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            yield return new WaitForSeconds(2);
            Zaina.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Table.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate1.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate2.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            Plate3.SetActive(true);
            Popup.Play();
            ZainaAnim.SetTrigger("talk");
            yield return new WaitForSeconds(1);
            Question1_Zaina_F.Play();
            yield return new WaitForSeconds(10);
            Question2_Zaina_F.Play();
            yield return new WaitForSeconds(3);
            Plate3Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num1_Zaina.Play();
            yield return new WaitForSeconds(1);
            Plate2Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num2_Zaina.Play();
            yield return new WaitForSeconds(1);
            Plate1Anim.SetTrigger("scale");
            yield return new WaitForSeconds(1);
            Num3_Zaina.Play();
            yield return new WaitForSeconds(1);
            B1.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B2.gameObject.SetActive(true);
            Popup.Play();
            yield return new WaitForSeconds(1);
            B3.gameObject.SetActive(true);
            Popup.Play();
            ZainaAnim.SetTrigger("smile");

        }

    }
}
