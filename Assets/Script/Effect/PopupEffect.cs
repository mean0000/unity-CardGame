using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupEffect : MonoBehaviour
{
    public float fadeTime = 1f;
    public CanvasGroup canvasGroup;
    public RectTransform rectTransform;



    void Start()
    {
        PanelFadeOut();

    }


    //나타나는
    public void PanelFadeIn()
    {
        Debug.Log("이벤트 발생");

        canvasGroup.alpha = 0f;
        rectTransform.transform.localScale = new Vector3(1f, 1f, 1f);
        rectTransform.DOAnchorPos(new Vector2(0f, 0f), fadeTime, false).SetEase(Ease.OutElastic);
        canvasGroup.DOFade(1, fadeTime);
    }

    //사라지는
    public void PanelFadeOut()
    {
        Debug.Log("왜 아노디지");
        canvasGroup.alpha = 1f;
        rectTransform.transform.localScale = new Vector3(1f, 1f, 1f);
        rectTransform.DOAnchorPos(new Vector2(0f, -10f), fadeTime, false).SetEase(Ease.InOutQuint);
        canvasGroup.DOFade(1, fadeTime);
    }

}
