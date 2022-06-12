using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSound : MonoBehaviour
{
    public AudioSource music;
    public Sprite on;
    public Sprite of;
    public Button button;
    public bool isOn = true;

    void Start()
    {
        of = button.image.sprite; //button to handle the backgroung sound
    }


    public void MuteControl()
    {

        if (isOn) //backgroung sound is unmuted
        {
            button.image.sprite = on;
            isOn = false;
            music.mute = true;

        }
        else //backgroung sound is muted
        {
            button.image.sprite = of;
            isOn = true;
            music.mute = false;
        }

    }
}
