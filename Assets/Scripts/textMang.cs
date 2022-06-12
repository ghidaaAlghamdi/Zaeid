using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System;
using System.Data;
using System.Text;
using System.Security.Cryptography;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Linq;

//This script manages the homepage texts according to the user's gender
public class textMang : MonoBehaviour
{
  
   string gender;
   string score;
    public Text scorerText ;
    public Text Ready = null ;
    public Text chooseL ;
    public Text chooseT1 = null ;
    public Text chooseT2  = null ;
    public Text chooseT3 = null ;
    public Text chooseT4 = null ;
    public Text chooseT5 = null ;
    public Text chooseT6 = null ;
    public Text LVremember = null ;
    public Text Taskremember = null ; 
    public Text want = null ; 
    public Text getScore = null ; 
   

      [System.Obsolete] 
      void Start() {
            StartCoroutine(GetScores());
            StartCoroutine(GetGender()); 
            if(gender == "ﻰﺜﻧﺃ")
        {
          chooseL.text = "ﺔﻠﺣﺮﻤﻟﺍ يﺭﺎﺘﺧﺍ";
          chooseT1.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT2.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT3.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT4.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT5.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT6.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          LVremember.text ="ﻚﻨﻜﻤﻳ ﻻ ﻱﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﺔﻠﺣﺮﻤﻟﺎﺑ ﺀﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﺔﻠﺣﺮﻤﻟﺍ ﻲﻠﻤﻜﺗ ﻢﻟ  ";
          Ready.text = "؟ ﺓﺪﻌﺘﺴﻣ ﻲﺘﻧﺍ ﻞﻫ";
          getScore.text = "ﺎﻬﻴﻠﻋ ﻲﺘﻠﺼﺣ ﻲﺘﻟﺍ ﻁﺎﻘﻨﻟﺍ ﻊﻴﻤﺟﻭ  \n ﻩﺎﻧﺩﺍ ﻞﻜﺸﻟﺍ ﻲﻓ ﺔﻧﺰﺨﻣ ﻥﻮﻜﺘﺳ";
          Taskremember.text = "ﻚﻨﻜﻤﻳ ﻻ ﻱﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﻡﺎﻬﻤﻟﺎﺑ ﺀﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﻡﺎﻬﻤﻟا ﻲﻠﻤﻜﺗ ﻢﻟ  ";
          want.text = " ؟ ﺝﻭﺮﺨﻟﺍ ﻞﻴﺠﺴﺗ ﻦﻳﺪﻳﺮﺗ ﻞﻫ";
            } 
        
 else if(gender == "ﺮﻛﺫ")
        {
          chooseL.text = "ﺔﻠﺣﺮﻤﻟﺍ ﺭﺎﺘﺧﺍ";
          chooseT1.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT2.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT3.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT4.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT5.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT6.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          LVremember.text = " ﻚﻨﻜﻤﻳ ﻻ ﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﺔﻠﺣﺮﻤﻟﺎﺑ ﺀﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﺔﻠﺣﺮﻤﻟﺍ ﻞﻤﻜﺗ ﻢﻟ   ";
          Ready.text = "؟ دﻌﺘﺴﻣ ﺖﻧﺍ ﻞﻫ";
          getScore.text = "ﺎﻬﻴﻠﻋ ﺖﻠﺼﺣ ﻲﺘﻟﺍ ﻁﺎﻘﻨﻟﺍ ﻊﻴﻤﺟﻭ  \n ﻩﺎﻧﺩﺍ ﻞﻜﺸﻟﺍ ﻲﻓ ﺔﻧﺰﺨﻣ ﻥﻮﻜﺘﺳ";
          Taskremember.text =" ﻚﻨﻜﻤﻳ ﻻ ﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﻡﺎﻬﻤﻟﺎﺑ ﺀﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﻡﺎﻬﻤﻟا ﻞﻤﻜﺗ ﻢﻟ  ";
          want.text = " ؟ ﺝﻭﺮﺨﻟﺍ ﻞﻴﺠﺴﺗ ﺪﻳﺮﺗ ﻞﻫ";
             }
      }

 [System.Obsolete]
       public IEnumerator GetScores(){

        WWWForm form = new WWWForm();

        form.AddField("UserID", Login.UserInfo.id);

            UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetScore.php", form);
      
            yield return www.SendWebRequest() ;


            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
               

            }
            else
            {
               score = www.downloadHandler.text;
               Debug.Log(score);

            }

              scorerText.text =  score + " / ٦٠٠";

        }
 [System.Obsolete]
        public IEnumerator GetGender(){

        WWWForm form = new WWWForm();

          form.AddField("UserID", Login.UserInfo.id);

            UnityWebRequest www = UnityWebRequest.Post("http://192.168.1.3/GetGender.php", form);
      
            yield return www.SendWebRequest() ;


            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
               

            }
            else
            {
               gender=www.downloadHandler.text;
            }

          if(gender == "ﻰﺜﻧﺃ")
        {
          chooseL.text = "ﺔﻠﺣﺮﻤﻟﺍ يﺭﺎﺘﺧﺍ";
          chooseT1.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT2.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT3.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT4.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT5.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          chooseT6.text =" ﻚﺘﻤﻬﻣ ﻱﺭﺎﺘﺧﺍ";
          LVremember.text ="ﻚﻨﻜﻤﻳ ﻻ ﻱﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﺔﻠﺣﺮﻤﻟﺎﺑ ﺀﺍﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﺔﻠﺣﺮﻤﻟﺍ ﻲﻠﻤﻜﺗ ﻢﻟ  ";
          Ready.text = "؟ ﺓﺪﻌﺘﺴﻣ ﻲﺘﻧﺍ ﻞﻫ";
          getScore.text = "ﺎﻬﻴﻠﻋ ﻲﺘﻠﺼﺣ ﻲﺘﻟﺍ ﻁﺎﻘﻨﻟﺍ ﻊﻴﻤﺟﻭ  \n ﻩﺎﻧﺩﺍ ﻞﻜﺸﻟﺍ ﻲﻓ ﺔﻧﺰﺨﻣ ﻥﻮﻜﺘﺳ";
          Taskremember.text = "ﻚﻨﻜﻤﻳ ﻻ ﻱﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﻡﺎﻬﻤﻟﺎﺑ ﺀﺍﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﻡﺎﻬﻤﻟا ﻲﻠﻤﻜﺗ ﻢﻟ  ";
          want.text = " ؟ ﺝﻭﺮﺨﻟﺍ ﻞﻴﺠﺴﺗ ﻦﻳﺪﻳﺮﺗ ﻞﻫ";
            } 
        
 else if(gender == "ﺮﻛﺫ")
        {
          chooseL.text = "ﺔﻠﺣﺮﻤﻟﺍ ﺭﺎﺘﺧﺍ";
          chooseT1.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT2.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT3.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT4.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT5.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          chooseT6.text = " ﻚﺘﻤﻬﻣ ﺭﺎﺘﺧﺍ";
          LVremember.text = " ﻚﻨﻜﻤﻳ ﻻ ﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﺔﻠﺣﺮﻤﻟﺎﺑ ﺀﺍﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﺔﻠﺣﺮﻤﻟﺍ ﻞﻤﻜﺗ ﻢﻟ   ";
          Ready.text = "؟ دﻌﺘﺴﻣ ﺖﻧﺍ ﻞﻫ";
          getScore.text = "ﺎﻬﻴﻠﻋ ﺖﻠﺼﺣ ﻲﺘﻟﺍ ﻁﺎﻘﻨﻟﺍ ﻊﻴﻤﺟﻭ  \n ﻩﺎﻧﺩﺍ ﻞﻜﺸﻟﺍ ﻲﻓ ﺔﻧﺰﺨﻣ ﻥﻮﻜﺘﺳ";
          Taskremember.text =" ﻚﻨﻜﻤﻳ ﻻ ﺮﻛﺬﺗ ﻦﻜﻟﻭ  \nﺎﻤﻟﺎﻃ ﺪﻳﺪﺠﻟﺍ ﻡﺎﻬﻤﻟﺎﺑ ﺀﺍﺪﺒﻟﺍ  \n ﺎﻬﻠﺒﻗ ﻲﺘﻟﺍ ﻡﺎﻬﻤﻟا ﻞﻤﻜﺗ ﻢﻟ  ";
          want.text = " ؟ ﺝﻭﺮﺨﻟﺍ ﻞﻴﺠﺴﺗ ﺪﻳﺮﺗ ﻞﻫ";
             }
        
        
        
        
         ///////////////////////////////////////////////

          // chooseT2.text = chooseT1.text;
          // chooseT3.text = chooseT1.text;
          // chooseT4.text = chooseT1.text;
          // chooseT5.text = chooseT1.text;
          // chooseT6.text = chooseT1.text;

        }

     

}
