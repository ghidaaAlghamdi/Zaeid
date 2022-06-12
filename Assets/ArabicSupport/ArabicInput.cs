using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ArabicSupport;
using UnityEngine.UI;

public class ArabicInput : MonoBehaviour
{
    [SerializeField]
    Text txtpreview;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GetComponent<InputField>().isFocused && Input.anyKeyDown)
        {
            txtpreview.text = ArabicFixer.Fix(GetComponent<InputField>().text);

        }
    }
}
