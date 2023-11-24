using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupEffect : MonoBehaviour
{
    public float fadeTime = 1f;
    public CanvasGroup canvasGroup_Finsh;
    public RectTransform rectTransform_Finsh;

    public CanvasGroup canvasGroup_Result;
    public RectTransform rectTransform_Result;



    void Start()
    {
        //PanelFadeOut();
        //PanelFadeOut_Result();
    }


    //나타나는
    public void PanelFadeIn()
    {
        Debug.Log("이벤트 발생");

        canvasGroup_Finsh.alpha = 0f;
        rectTransform_Finsh.transform.localScale = new Vector3(1f, 1f, 1f);
        rectTransform_Finsh.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
        canvasGroup_Finsh.DOFade(1, fadeTime);
    }

    //사라지는
    //public void PanelFadeOut()
    //{
    //    Debug.Log("이펙트 아웃");
    //    canvasGroup_Finsh.alpha = 1f;
    //    rectTransform_Finsh.transform.localScale = new Vector3(1f, 1f, 1f);
    //    rectTransform_Finsh.DOAnchorPos(new Vector2(0f, -10f), fadeTime, false).SetEase(Ease.InOutQuint);
    //    canvasGroup_Finsh.DOFade(1, fadeTime);
    //}



    //public void PanelFadeIn_Rusult()
    //{
    //    Debug.Log("5레벨 이후 이벤트 발생");

    //    canvasGroup_Result.alpha = 0f;
    //    rectTransform_Result.transform.localScale = new Vector3(1f, 1f, 1f);
    //    rectTransform_Result.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
    //    canvasGroup_Result.DOFade(1, fadeTime);
    //}

    //사라지는
    public void PanelFadeOut_Result()
    {
        Debug.Log("5레벨 이후 이벤트 발생");
        canvasGroup_Result.alpha = 1f;
        rectTransform_Result.transform.localScale = new Vector3(1f, 1f, 1f);
        rectTransform_Result.DOAnchorPos(new Vector2(0f, -10f), fadeTime, false).SetEase(Ease.InOutQuint);
        canvasGroup_Result.DOFade(1, fadeTime);
    }

}
