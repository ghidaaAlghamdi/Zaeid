using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenderDropdown : MonoBehaviour
{
    
    void Start()
    {
        //create a dropdown menu to hold the genders info
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        dropdown.captionText.text = "ﺲﻨﺠﻟﺍ";

        //dropdown menu options 
        List<string> items = new List<string>();
        items.Add("ﻰﺜﻧﺃ");
        items.Add("ﺮﻛﺫ");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }
    }

    
    void Update()
    {
        
    }
}
