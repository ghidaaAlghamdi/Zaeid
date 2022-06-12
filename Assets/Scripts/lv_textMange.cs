using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


//This script manages the texts inside the actual levels according to the user's gender
public class lv_textMange : MonoBehaviour
{

    public Text playing ;
    public Text played ;
    public Text taskNumberPlayed ;
    public Text taskNumberPlaying ;
    public Text  backToHomeMessage;
    public string tasknumber;


    
    void Start()
    {   
     
        if(GetInformation.Getinfo.Gender =="ﺮﻛﺫ")
        {
            playing.text= "ﺓﺪﻳﺪﺟ ﺎﻃﺎﻘﻧ ﺕﺯﺮﺣﺃ ﺪﻘﻟ";
            played.text= "ﺎﻘﺑﺎﺳ ﻪﺘﻤﻠﻌﺗﺎﻣ ﺲﻨﺗ ﻢﻟ";
            taskNumberPlayed.text= tasknumber+"ﺔﻤﻬﻤﻟﺍ ﺖﻨﻘﺗﺃ";
            taskNumberPlaying.text=tasknumber+" ﺔﻤﻬﻤﻟﺍ ﺖﻠﻤﻛﺃ";
            backToHomeMessage.text= "ﺔﺒﻌﻠﻟﺍ ﻑﺎﻘﻳﺍ ﻦﻣ ﺪﻛﺎﺘﻣ ﺖﻧﺍ ﻞﻫ ؟ﺔﻴﺴﻴﺋﺮﻟﺍ ﺔﺤﻔﺼﻠﻟ ﺓﺩﻮﻌﻟﺍﻭ";                                      

         } else 
        {

            playing.text= "ﺓﺪﻳﺪﺟ ﺎﻃﺎﻘﻧ ﻲﺗﺯﺮﺣﺃ ﺪﻘﻟ";
            played.text="ﺎﻘﺑﺎﺳ ﻪﺘﻤﻠﻌﺗﺎﻣ ﻲﺴﻨﺗ ﻢﻟ";
            taskNumberPlayed.text= tasknumber+" ﺔﻤﻬﻤﻟﺍ ﻲﺘﻨﻘﺗﺃ";
            taskNumberPlaying.text= tasknumber+" ﺔﻤﻬﻤﻟﺍ ﻲﺘﻠﻤﻛﺃ";
            backToHomeMessage.text="ﺔﺒﻌﻠﻟﺍ ﻑﺎﻘﻳﺍ ﻦﻣ ﺓﺪﻛﺎﺘﻣ ﻲﺘﻧﺍ ﻞﻫ ؟ﺔﻴﺴﻴﺋﺮﻟﺍ ﺔﺤﻔﺼﻠﻟ ﺓﺩﻮﻌﻟﺍﻭ";


        }  
    }

    }
