using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TweenMainMenu : MonoBehaviour
{

    [SerializeField]
    GameObject PlayButton, OptionsButton, QuitButton, volumeSlider,
    vibrToggle, backButton, BackPanel, playObjects, optionsObjects;


    void Awake()
    {
        playObjects.SetActive(true);
        optionsObjects.SetActive(false);
        PlayButton.transform.localScale = new Vector3(0f, 0f, 0f);
        OptionsButton.transform.localScale = new Vector3(0f, 0f, 0f);
        QuitButton.transform.localScale = new Vector3(0f, 0f, 0f);
        volumeSlider.transform.localScale = new Vector3(0f, 0f, 0f);
        vibrToggle.transform.localScale = new Vector3(0f, 0f, 0f);
        backButton.transform.localScale = new Vector3(0f, 0f, 0f);
        BackPanel.transform.localScale = new Vector3(0f, 0f, 0f);
        StartTween();
    }
    public void Play()
    {
        PlayTween();
    }


    public void Options()
    {
        optionsObjects.SetActive(true);
        OptionsTween();
    }

    public void Back()
    {
        playObjects.SetActive(true);
        LeanTween.scale(volumeSlider, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.1f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(vibrToggle, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.2f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(backButton, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.3f).setEase(LeanTweenType.easeInQuart);

        LeanTween.scale(PlayButton, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.6f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(OptionsButton, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.7f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(QuitButton, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.8f).setEase(LeanTweenType.easeOutCirc)
        .setOnComplete(OptionsActivateFalse);


    }

    void OptionsActivateFalse()
    {
        optionsObjects.SetActive(false);
    }
    public void Quit()
    {
        QuitTween();

    }

    public void MainMenu()
    {
        PlayTween();
        SceneManager.LoadScene("Main Menu");

    }

    void PlayTween()
    {
        LeanTween.scale(PlayButton, new Vector3(0f, 0f, 0f), 0.6f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(OptionsButton, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.1f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(QuitButton, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.2f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(BackPanel, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.3f).setEase(LeanTweenType.easeInQuart)
        .setOnComplete(LoadGame);

    }
    void OptionsTween()
    {

        LeanTween.scale(PlayButton, new Vector3(0f, 0f, 0f), 0.6f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(OptionsButton, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.1f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(QuitButton, new Vector3(0f, 0f, 0f), 0.6f).setDelay(.2f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(volumeSlider, new Vector3(1f, 1f, 1f), 0.6f).setDelay(.5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(vibrToggle, new Vector3(1f, 1f, 1f), 0.6f).setDelay(.6f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(backButton, new Vector3(1f, 1f, 1f), 0.6f).setDelay(.7f).setEase(LeanTweenType.easeOutCirc)
        .setOnComplete(playOptionsTrue);

    }
    void playOptionsTrue()
    {
        playObjects.SetActive(false);
    }

    void QuitTween()
    {
        LeanTween.scale(QuitButton, new Vector3(0f, 0f, 0f), 0.3f);
        LeanTween.scale(OptionsButton, new Vector3(0f, 0f, 0f), 0.3f).setDelay(.1f);
        LeanTween.scale(PlayButton, new Vector3(0f, 0f, 0f), 0.3f).setDelay(.2f);
        LeanTween.scale(BackPanel, new Vector3(0f, 0f, 0f), 0.3f).setDelay(.3f).setOnComplete(QuitGame);
    }
    void StartTween()
    {
        LeanTween.scale(BackPanel, new Vector3(1f, 1f, 1f), 0.9f).setDelay(.3f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(PlayButton, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.6f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(OptionsButton, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.7f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(QuitButton, new Vector3(1f, 1f, 1f), 0.7f).setDelay(.8f).setEase(LeanTweenType.easeOutCirc);

    }

    void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game Quit");
    }

}
