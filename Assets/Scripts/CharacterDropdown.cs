using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterDropdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //create a dropdown menu to hold characters info
        var dropdown = transform.GetComponent<Dropdown>();
        dropdown.options.Clear();
        dropdown.captionText.text = "ﺔﻴﺼﺨﺸﻟﺍ"; //dropdown menu placeholder

        //dropdown menu options 
        List<string> items = new List<string>();
        items.Add("ﺪﺋﺍﺯ");
        items.Add("ﺔﻨﻳﺯ");

        foreach (var item in items)
        {
            dropdown.options.Add(new Dropdown.OptionData() { text = item });
        }
    }

}
