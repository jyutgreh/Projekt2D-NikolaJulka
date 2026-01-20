using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public AudioMixer audioMixer;
    private bool musicMuted = false;
    private bool sfxMuted = false;
    public GameObject menu;
    private bool menuActive = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuActive = !menuActive;
            menu.SetActive(menuActive);
        }
    }
    
    public void Restart()
    {
        SceneManager.LoadScene("TopDown_Nikola");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }

    public void ButtonMusicMute()
    {
        musicMuted = !musicMuted;
        if (musicMuted)
        {
            audioMixer.SetFloat("MusicVolume", -80f);
        }
        else
        {
            audioMixer.SetFloat("MusicVolume", 0f);
        }
    }

    public void ButtonSFXMute()
    {
        sfxMuted = !sfxMuted;
        if (musicMuted)
        {
            audioMixer.SetFloat("SFXVolume", -80f);
        }
        else
        {
            audioMixer.SetFloat("SFXVolume", 0f);
        }
    }

    public void SetMusicVolume(float sliderValue)
    {
        float db = Mathf.Lerp(-80f, 20, sliderValue);
        audioMixer.SetFloat("MusicVolume", db);
    }

    public void SetSFXVolume(float sliderValue)
    {
        float db = Mathf.Lerp(-80f, 20, sliderValue);
        audioMixer.SetFloat("SFXVolume", db);
    }


}
 