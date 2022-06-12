using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;


public class intro_textMange : MonoBehaviour
{
    public Text backToHomeMessage;


    void Start()
    {   
     
        if(GetInformation.Getinfo.Gender =="ﺮﻛﺫ")
        {

            backToHomeMessage.text= "ﺔﺒﻌﻠﻟﺍ ﻑﺎﻘﻳﺍ ﻦﻣ ﺪﻛﺎﺘﻣ ﺖﻧﺍ ﻞﻫ ؟ﺔﻴﺴﻴﺋﺮﻟﺍ ﺔﺤﻔﺼﻠﻟ ﺓﺩﻮﻌﻟﺍﻭ";                                      

         } else 
        {
            backToHomeMessage.text="ﺔﺒﻌﻠﻟﺍ ﻑﺎﻘﻳﺍ ﻦﻣ ﺓﺪﻛﺎﺘﻣ ﻲﺘﻧﺍ ﻞﻫ ؟ﺔﻴﺴﻴﺋﺮﻟﺍ ﺔﺤﻔﺼﻠﻟ ﺓﺩﻮﻌﻟﺍﻭ";


        }  
    }

    }
