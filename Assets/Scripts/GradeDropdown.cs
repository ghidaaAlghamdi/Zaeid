using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GradeDropdown : MonoBehaviour
{


    void Start()
    {
        //create a dropdown menu to hold the genders info
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        dropdown.captionText.text = "ﻒﺼﻟﺍ";

        //dropdown menu options 
        List<string> items = new List<string>();
        items.Add("ﻝﻭﻷﺍ ﻒﺼﻟﺍ");
        items.Add("ﻲﻧﺎﺜﻟﺍ ﻒﺼﻟﺍ");
        items.Add("ﺚﻟﺎﺜﻟﺍ ﻒﺼﻟﺍ");
        items.Add("ﻊﺑﺍﺮﻟﺍ ﻒﺼﻟﺍ");
        items.Add("ﺲﻣﺎﺨﻟﺍ ﻒﺼﻟﺍ");
        items.Add("ﺱﺩﺎﺴﻟﺍ ﻒﺼﻟﺍ");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }

    }

}
