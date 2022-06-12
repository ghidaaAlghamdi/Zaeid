using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArabicSupport;
using UnityEngine.UI;

public class FixText : MonoBehaviour
{
    [SerializeField]
    Text txt;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            txt.text = ArabicFixer.Fix(txt.text);


    }
}
