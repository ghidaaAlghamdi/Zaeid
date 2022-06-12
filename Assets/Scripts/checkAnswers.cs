using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

//This script handles actions based on users answers and behaviors during the game
public class checkAnswers : MonoBehaviour
{

    public GameObject played; //Scoreboard shows when replaying the task
    public GameObject playing; //Scoreboard shows after passing the task for the first time
    public Button correctA; //Correct answer
    public Button wrongA1; //Wrong answer
    public Button wrongA2; //Wrong answer

    public AudioSource popSound;
    public AudioSource buzSound;
    public AudioSource winSound;
    public AudioSource click;
 
    public Animator zainahAn;
    public Animator zaeidAn;


    public int time1 = 0; //Initialize timer with 0 and act as a counter to  wait for the user to answer  
    public Text time2; //Initialized for each task differently accourding to the task duration
    public bool stop = false;


    //Zaeid sounds 
    public AudioSource motivateZaeidM;
    public AudioSource encourageZaeidM;
    public AudioSource cheerupZaeidM;
    public AudioSource cheerupZaeidF;
    public AudioSource motivateZaeidF;
    public AudioSource encourageZaeidF;

    //Zaina sounds
    public AudioSource encourageZainahF;
    public AudioSource cheerupZainahF;
    public AudioSource motivateZainahF;
    public AudioSource encourageZainahM;
    public AudioSource cheerupZainahM;
    public AudioSource motivateZainahM;

    
    public int NewScore; 
    public int OldScore;
    public Text ScoreNO;
    public int Score;
    public int nextlvl;
    public int nexttask;
    public string taskState;




    [System.Obsolete]
    void Start()
    {

        stop = false;
    }



    [System.Obsolete]
    //Start counting from 0 untill specifed time according to "time2"
	//If time reached "time2" before the user choosees an answer play the character motivation animation and sound
    //Animation and sound is set according to the user's gender and  choice of character
    void FixedUpdate() 
    {
        if (GetInformation.Getinfo.SelectedCharacter == "M" && stop == true)
        {
            //zaeidAn.gameObject.GetComponent<Animator>().enabled = false;
            motivateZaeidM.Stop();
            motivateZaeidF.Stop();
        }
        if (GetInformation.Getinfo.SelectedCharacter == "F"&& stop==true)
        {
            //zainahAn.gameObject.GetComponent<Animator>().enabled = false;
            motivateZainahM.Stop();
            motivateZainahF.Stop();
        }

        else if (GetInformation.Getinfo.SelectedCharacter == "M"&& stop==true)
        {
            //zaeidAn.gameObject.GetComponent<Animator>().enabled = false;
            motivateZaeidM.Stop();
            motivateZaeidF.Stop();
        }
        if (!Input.anyKey && stop == false)
        {
            //Starts counting when no button is being pressed
            time1 = time1 + 1;
        }
        else
        {
            // If a button is being pressed restart counter to Zero
            time1 = 0;
        }
        //Now after 100 frames of nothing being pressed it will do activate this if statement
        if (time1 == int.Parse(time2.text))
        {
            //Now set time to zero so this happens every 25 frames
            if (GetInformation.Getinfo.SelectedCharacter == "F")
            {
                zainahAn.SetTrigger("talk");
                if (GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
                {
                    motivateZainahF.Play();
                    StartCoroutine(waitSmile());
                }
                else
                {
                    motivateZainahM.Play();
                    StartCoroutine(waitSmile());
                }
            }
            else
            {
                zaeidAn.SetTrigger("talk");
                if (GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
                {
                    motivateZaeidM.Play();
                    StartCoroutine(waitSmile());
                }
                else
                {
                    motivateZaeidF.Play();
                    StartCoroutine(waitSmile());
                }
            }
            time1 = 0;
        }
    }

    public IEnumerator waitSmile()
    {
        yield return new WaitForSeconds(5);
        zainahAn.SetTrigger("smile");
    }

    public void CallWrongAnswer()
    {
        StartCoroutine(chooseWrongAnswer());
    }

    //called when the user chooses a wrong answer
    public IEnumerator chooseWrongAnswer()
    {
        buzSound.Play();
        if (GetInformation.Getinfo.SelectedCharacter  == "F")
        {
            zainahAn.SetTrigger("sad");

            if (GetInformation.Getinfo.Gender == "M")
            {
                encourageZainahM.Play();
                yield return new WaitForSeconds(2);
                zainahAn.SetTrigger("smile");
            }
            else
            {
                encourageZainahF.Play();
                yield return new WaitForSeconds(2);
                zainahAn.SetTrigger("smile");
            }
        }
        else
        {
            zaeidAn.SetTrigger("sad");
            if (GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
            {
                encourageZaeidM.Play();
                yield return new WaitForSeconds(2);
                zaeidAn.SetTrigger("smile");
            }
            else
            {
                encourageZaeidF.Play();
                yield return new WaitForSeconds(2);
                zaeidAn.SetTrigger("smile");
            }

        }


    }


    //called when the user chooses the right answer
    public void chooseRightAnswer()
    {
        stop=true;

        StartCoroutine(Correct());
    }

    public IEnumerator Correct()
    {
        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

        WWW www = new WWW("http://192.168.1.3/GetScore.php", form);

        yield return www;

        string en = "";

        //Fetch score and convert to english number for easy handling
        for (int i = 0; i < www.text.Length; i++)
        {
            en += char.GetNumericValue(www.text, i);
        }

        OldScore = int.Parse(en);


        if (OldScore >= Score) //in case of replaying the task
        {
            StartCoroutine(playedScoreBoard());
            if (GetInformation.Getinfo.SelectedCharacter == "F")
            {
                zainahAn.SetTrigger("clap");
                StartCoroutine(WaitBeforecheerup());
            }
            else
            {
                zaeidAn.SetTrigger("clap");
                StartCoroutine(WaitBeforecheerup());
            }
            NewScore = OldScore; //no need to update the scores
        }
        else //in case of playing for the first time
        {
            StartCoroutine(NotplayedScoreBoard());
            if (GetInformation.Getinfo.SelectedCharacter == "F")
            {
                zainahAn.SetTrigger("clap");
                StartCoroutine(WaitBeforecheerup());
            }
            else
            {
                zaeidAn.SetTrigger("clap");
                StartCoroutine(WaitBeforecheerup());
            }
            NewScore = Score; //update scores
            StartCoroutine(Updatelvlntask()); //update the level and task number to the next one

            IEnumerator Updatelvlntask()
            {
                WWWForm form = new WWWForm();
                form.AddField("UserID", Login.UserInfo.id);
                form.AddField("Lvl", nextlvl);
                form.AddField("Task", nexttask);

                WWW www = new WWW("http://192.168.1.3/Updatelvlntask.php", form);

                yield return www;

                if (www.text[0] == '0')
                {
                    Debug.Log("succsess on updating lvl&task");
                }
                else
                {
                    Debug.Log("failed on updating lvl&task");
                }
            }
        }

        string sc = NewScore.ToString();

        //Convert the score to arabic number to display and store
        var ar = new string[10] { "٠", "١", "٢", "٣", "٤", "٥", "٦", "٧", "٨", "٩" };
        for (int j = 0; j < ar.Length; j++)
        {
            sc = sc.Replace(j.ToString(), ar[j]);
        }


        StartCoroutine(setScores());

        IEnumerator setScores()
        {
            WWWForm form = new WWWForm();
            form.AddField("UserID", Login.UserInfo.id);
            form.AddField("Scores", sc);

            WWW www = new WWW("http://192.168.1.3/UpdateScores.php", form);

            yield return www;

            if (www.text[0] == '0')
            {
                Debug.Log("succsess");
            }
            else
            {
                Debug.Log("failed");
            }
        }


    }

    //Cheering up the user after choosing the correct answer
    private IEnumerator WaitBeforecheerup()
    {
        yield return new WaitForSeconds((float)0.5);
        if (GetInformation.Getinfo.SelectedCharacter  == "F" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            cheerupZainahF.Play();
        }
        else if (GetInformation.Getinfo.SelectedCharacter  == "F" && GetInformation.Getinfo.Gender == "ﺮﻛﺫ")
        {
            cheerupZainahM.Play();
        }
        else if (GetInformation.Getinfo.SelectedCharacter  == "M" && GetInformation.Getinfo.Gender == "ﻰﺜﻧﺃ")
        {
            cheerupZaeidF.Play();
        }
        else
        {
            cheerupZaeidM.Play();
        }

    }

    private IEnumerator NotplayedScoreBoard()
    {
        yield return new WaitForSeconds(5);

            popSound.Play();
            played.SetActive(false);
            playing.SetActive(true);
    }

    private IEnumerator playedScoreBoard()
    {
        yield return new WaitForSeconds(5);

        popSound.Play();
        played.SetActive(true);
        playing.SetActive(false);
    }

    public void replay()
    {

        click.Play();
        taskState = "p";
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }


}
