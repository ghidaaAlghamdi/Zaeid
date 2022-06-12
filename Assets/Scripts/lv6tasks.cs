using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

public class lv6tasks : MonoBehaviour
{
    int task=8;
    static string Task;

    [System.Obsolete]
    void Start()
    {
        StartCoroutine(GetTaskNo());
    }

    [System.Obsolete]



    public IEnumerator GetTaskNo()
    {

        WWWForm form = new WWWForm();
        form.AddField("UserID", Login.UserInfo.id);

        UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetTask.php", form);

        yield return www.SendWebRequest();


        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);


        }
        else
        {
            Task = www.downloadHandler.text;
            task = (int)System.Convert.ToInt32(Task);
            Debug.Log(Task);
            Debug.Log(task);
        }

        for (int i = 1; i < 7; i++)
        {

            string sprite = "taskO-" + i;

            int ts = 1;
            bool click = true;

            if (Switch.level > 6)
            {

                ts = i;
                sprite = "taskS-" + i;


            }


            if ((Switch.level == 6) && (task >= i - 1))
            {

                ts = i;
                sprite = "taskS-" + i;

            }

            if ((Switch.level == 6) && (task <= i - 1))
            {
                sprite = "taskC-" + i;
                click = false;

            }

            if ((Switch.level == 6) && (task == i - 1))
            {

                ts = i;
                sprite = "taskO-" + i;

            }

            GameObject bt = Instantiate(Resources.Load("Prefab/ButtonPanel") as GameObject);
            bt.transform.SetParent(GameObject.FindGameObjectWithTag("tasks").transform, false);
            bt.transform.Find("Button").GetComponent<Image>().sprite = Resources.Load<Sprite>(sprite);
            bt.transform.Find("Button").GetComponent<Button>().onClick.AddListener(() => BTN_Click(ts));
            bt.transform.Find("Button").GetComponent<Button>().interactable = click;


        }

    }





    private void BTN_Click(int ts)
    {
        SceneManager.LoadScene("l" + 6 + "t" + ts);

    }
}
