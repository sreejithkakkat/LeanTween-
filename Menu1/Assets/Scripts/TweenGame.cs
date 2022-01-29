using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TweenGame : MonoBehaviour
{
    [SerializeField] GameObject yesOrNoPanel, yesBtn, noBtn, quitBtn, gameText;
    void Awake()
    {
        yesOrNoPanel.transform.localScale = new Vector3(0f, 0f, 0f);
        yesBtn.transform.localScale = new Vector3(0f, 0f, 0f);
        noBtn.transform.localScale = new Vector3(0f, 0f, 0f);
        quitBtn.transform.localScale = new Vector3(0f, 0f, 0f);
        gameText.transform.localScale = new Vector3(0f, 0f, 0f);

    }
    void Start()
    {
        LeanTween.scale(quitBtn, new Vector3(1f, 1f, 1f), .5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(gameText, new Vector3(1f, 1f, 1f), .5f).setEase(LeanTweenType.easeOutCirc);

    }

    public void QuitButton()
    {
        PanelEnable();
    }

    public void YesButton()
    {
        LeanTween.scale(gameText, new Vector3(0f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(yesBtn, new Vector3(0f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(noBtn, new Vector3(0f, 0f, 0f), .5f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        //LeanTween.moveLocal(yesOrNoPanel, new Vector3(0f, -615f, 0f), 0.5f).setDelay(.1f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(yesOrNoPanel, new Vector3(0f, 0f, 0f), .5f).setDelay(.1f).setEase(LeanTweenType.easeInQuart)
        .setOnComplete(LoadMainMenu);
    }
    public void NoButton()
    {

        LeanTween.scale(yesBtn, new Vector3(0f, 0f, 0f), .5f).setDelay(.1f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(noBtn, new Vector3(0f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.moveLocal(yesOrNoPanel, new Vector3(0f, -615f, 0f), 0.5f).setDelay(.1f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(yesOrNoPanel, new Vector3(0f, 0f, 0f), .5f).setDelay(.1f).setEase(LeanTweenType.easeInQuart);
        LeanTween.scale(quitBtn, new Vector3(1f, 1f, 1f), .5f).setDelay(.7f).setEase(LeanTweenType.easeOutCirc);
    }


    void PanelEnable()
    {
        LeanTween.scale(quitBtn, new Vector3(0f, 0f, 0f), .5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.moveLocal(yesOrNoPanel, new Vector3(0f, 0f, 0f), 0.5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(yesOrNoPanel, new Vector3(2f, 2f, 1f), .5f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(yesBtn, new Vector3(1.5f, 1.5f, 1.5f), .5f).setDelay(.3f).setEase(LeanTweenType.easeOutCirc);
        LeanTween.scale(noBtn, new Vector3(1.5f, 1.5f, 1.5f), .5f).setDelay(.4f).setEase(LeanTweenType.easeOutCirc);

    }



    void LoadMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
