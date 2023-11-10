using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class PageManager : MonoBehaviour
{
    public static PageManager Instance;

    [SerializeField]
    private GameObject gameStart;
    [SerializeField] 
    private GameObject camera;
    [SerializeField]
    private GameObject gameAgree;
    [SerializeField]
    private GameObject gameSelect;
    [SerializeField]
    private GameObject gameEffect;
    [SerializeField]
    private GameObject gamePlay;
    [SerializeField]
    private GameObject gameResult;

    [SerializeField]
    private Image BlackBack;
    [SerializeField]
    private Image BlackBack2;
    //암전되는 시간
    float fadeDuration = 1.2f;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    public void ChangeView_Load(int viewDivnum)
    {
        switch (viewDivnum)
        {
            case 0:
                gameStart.SetActive(false);
                camera.SetActive(true);
                break;
            case 1:
                BlackBack2.DOFade(2, fadeDuration).OnComplete(() =>
                {
                    camera.SetActive(false);
                    gameAgree.SetActive(true);
                });
                break;
            case 2:
                gameAgree.SetActive(false);
                gameSelect.SetActive(true);
                break;
            case 3:
                gameEffect.SetActive(false);
                BlackBack.DOFade(1, fadeDuration).OnComplete(() =>
                {
                    LevelManager.Instance.Level_Easy();
                    BlackBack.DOFade(0, fadeDuration);
                });
                break;
            case 4:
                gameEffect.SetActive(false);
                BlackBack.DOFade(1, fadeDuration).OnComplete(() =>
                {
                    LevelManager.Instance.Level_Normal();
                    BlackBack.DOFade(0, fadeDuration);
                });
                break;
            case 5:
                gameEffect.SetActive(false);
                BlackBack.DOFade(1, fadeDuration).OnComplete(() =>
                {
                    LevelManager.Instance.Level_Hard();
                    BlackBack.DOFade(0, fadeDuration);
                });
                break;

            case 6:
                //gameEffect.SetActive(false);
                BlackBack.DOFade(1, fadeDuration).OnComplete(() =>
                {
                    gamePlay.SetActive(false);
                    gameResult.SetActive(true);
                });
                break;
        }
    }

    public void ButtonEvent_Disagree()
    {
        Application.Quit();
    }

    public void ButtoEvent_GameQuit()
    {
        Application.Quit();
    }
}
