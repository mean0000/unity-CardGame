using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageManager : MonoBehaviour
{
    [SerializeField]
    private GameObject gameStart;
    [SerializeField] 
    private GameObject camera;
    [SerializeField]
    private GameObject gameAgree;
    [SerializeField]
    private GameObject gameSelect;

    public void ButtonEvent_Start()
    {
        gameStart.SetActive(false);
        gameAgree.SetActive(true);
    }

    public void CameraView()
    {
        //카메라 기능 개발 후 이용
    }

    public void ButtonEvent_Agree()
    {
        gameAgree.SetActive(false);
        gameSelect.SetActive(true);
    }

    public void ButtonEvent_Disagree()
    {
        Application.Quit();
    }
}
