using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
/**
 * Yalnýzca on/off butonlarýnýn toggle görüntüsü yapýldý. Ayrýca 
 * kullanýcý seçimi kaydediliyor PlayerPrefs ile. Ayarlar oyun içinde
 * herhangi bir þeye baðlý deðil.
 */
public class settings : MonoBehaviour
{
    public TMP_Text musicOn;
    public TMP_Text musicOff;
    public TMP_Text soundOn;
    public TMP_Text soundOff;
    public TMP_Text notifsOn;
    public TMP_Text notifsOff;

    public TMP_FontAsset on;
    public TMP_FontAsset off;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerPrefs.DeleteKey("music");
        //PlayerPrefs.DeleteKey("sound");
        //PlayerPrefs.DeleteKey("notifs");
        if (!PlayerPrefs.HasKey("music"))
        {
            PlayerPrefs.SetInt("music", 1);
        }
        else
        {
            int temp = PlayerPrefs.GetInt("music");
            if (temp == 1)
            {
                MusicOn();
            }
            else
            {
                MusicOff();
            }
        }

        if (!PlayerPrefs.HasKey("sound"))
        {
            PlayerPrefs.SetInt("sound", 1);
        }
        else
        {
            int temp = PlayerPrefs.GetInt("sound");
            if (temp == 1)
            {
                SoundOn();
            }
            else
            {
                SoundOff();
            }
        }

        if (!PlayerPrefs.HasKey("notifs"))
        {
            PlayerPrefs.SetInt("notifs", 1);
        }
        else
        {
            int temp = PlayerPrefs.GetInt("notifs");
            if (temp == 1)
            {
                NotifsOn();
            }
            else
            {
                NotifsOff();
            }
        }
    }

    public void MusicOn()
    {
        musicOn.font = on;
        musicOff.font = off;
        PlayerPrefs.SetInt("music", 1);
    }

    public void MusicOff()
    {
        musicOn.font = off;
        musicOff.font = on;
        PlayerPrefs.SetInt("music", 0);
    }

    public void SoundOn()
    {
        soundOn.font = on;
        soundOff.font = off;
        PlayerPrefs.SetInt("sound", 1);
    }

    public void SoundOff()
    {
        soundOn.font = off;
        soundOff.font = on;
        PlayerPrefs.SetInt("sound", 0);
    }

    public void NotifsOn()
    {
        notifsOn.font = on;
        notifsOff.font = off;
        PlayerPrefs.SetInt("notifs", 1);
    }

    public void NotifsOff()
    {
        notifsOn.font = off;
        notifsOff.font = on;
        PlayerPrefs.SetInt("notifs", 0);
    }
}
