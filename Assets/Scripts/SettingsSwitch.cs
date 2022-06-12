using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsSwitch : MonoBehaviour
{

    public GameObject ShowComponent;
    public GameObject EditPaper;
    public GameObject DeletePaper;
    public Text Email;

    void Start()
    {

    }

    public void Edit()
    {
        ShowComponent.SetActive(true);
        EditPaper.SetActive(true);
    }

    public void Delete()
    {
        ShowComponent.SetActive(true);
        DeletePaper.SetActive(true);
    }

    public void ExitEdit()
    {
        ShowComponent.SetActive(false);
        EditPaper.SetActive(false);
    }

    public void ExitDelete()
    {
        ShowComponent.SetActive(false);
        DeletePaper.SetActive(false);
    }
}
