using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FocusDetect : MonoBehaviour
{
    public InputField inputfield;
    public Canvas err;
    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        //Show error messgae popup when the inputfield is focused
        if (inputfield.isFocused)
        {
            err.gameObject.SetActive(true);
        }
    }
}
