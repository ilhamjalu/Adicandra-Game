using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    OnCollision onC;
    public Button playButton, mute, playSound;
    public GameObject settingObj, pauseObj, infoObj;
    public AudioSource menuAud;
    


    public void Play()
    {
        Application.LoadLevel(1);
    }

    public void Setting()
    {
        settingObj.SetActive(true);
        playButton.gameObject.SetActive(false);
        mute.gameObject.SetActive(true);
    }

    public void Info()
    {
        infoObj.SetActive(true);
        playButton.gameObject.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }

    public void BackButton()
    {
        settingObj.SetActive(false);
        infoObj.SetActive(false);
        playButton.gameObject.SetActive(true);
    }

    public void Pause()
    {
        pauseObj.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseObj.SetActive(false);
        Time.timeScale = 1;
    }

    public void Restart()
    {
        Application.LoadLevel(0);
    }

    public void Mute()
    {
        if (menuAud.isPlaying)
        {
            menuAud.Pause();
            playSound.gameObject.SetActive(true);
            mute.gameObject.SetActive(false);
        }
        else
        {
            menuAud.Play();
            mute.gameObject.SetActive(true);
            playSound.gameObject.SetActive(false);
        }
    }
}
