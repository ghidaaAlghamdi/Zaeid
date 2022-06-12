using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class textMange : MonoBehaviour
{
    public Text playing ;
    public Text played ;
    public Text taskNumberPlayed ;
    public Text taskNumberPlaying ;
    public Text backToHomeMessage ;

    static string userId = 2.ToString();
    public string tasknumber;



    // Start is called before the first frame update
    void Start()
    {   
        if(GetInformation.Getinfo.Gender =="ﺮﻛﺫ")
        {maleText();}
        else 
        {femaleText();}  

    }

    //Texts with the female pronoun
    public void femaleText()
    {

        playing.text= "ﺓﺪﻳﺪﺟ ﺎﻃﺎﻘﻧ ﻲﺗﺯﺮﺣﺃ ﺪﻘﻟ";
        played.text="ﺎﻘﺑﺎﺳ ﻪﺘﻤﻠﻌﺗﺎﻣ ﻲﺴﻨﺗ ﻢﻟ";
        taskNumberPlayed.text=tasknumber+" ﺔﻤﻬﻤﻟﺍ ﻲﺘﻨﻘﺗﺃ";
        taskNumberPlaying.text=tasknumber+"ﺔﻤﻬﻤﻟﺍ ﻲﺘﻠﻤﻛﺃ";
        backToHomeMessage.text="ﺔﺒﻌﻠﻟﺍ ﻑﺎﻘﻳﺍ ﻦﻣ ﺓﺪﻛﺎﺘﻣ ﻲﺘﻧﺍ ﻞﻫ ؟ﺔﻴﺴﻴﺋﺮﻟﺍ ﺔﺤﻔﺼﻠﻟ ﺓﺩﻮﻌﻟﺍﻭ";

    }

    //Texts with the male pronoun
    public void maleText()
    {
        playing.text= "ﺓﺪﻳﺪﺟ ﺎﻃﺎﻘﻧ ﺕﺯﺮﺣﺃ ﺪﻘﻟ";
        played.text= "ﺎﻘﺑﺎﺳ ﻪﺘﻤﻠﻌﺗﺎﻣ ﺲﻨﺗ ﻢﻟ";
        taskNumberPlayed.text=tasknumber+" ﺔﻤﻬﻤﻟﺍ ﺖﻨﻘﺗﺃ";
        taskNumberPlaying.text=tasknumber+"ﺔﻤﻬﻤﻟﺍ ﺖﻠﻤﻛﺃ";
        backToHomeMessage.text= "ﺔﺒﻌﻠﻟﺍ ﻑﺎﻘﻳﺍ ﻦﻣ ﺓﺪﻛﺎﺘﻣ ﺖﻧﺍ ﻞﻫ ؟ﺔﻴﺴﻴﺋﺮﻟﺍ ﺔﺤﻔﺼﻠﻟ ﺓﺩﻮﻌﻟﺍﻭ"; 
    }


}
