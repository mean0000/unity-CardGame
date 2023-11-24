using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowEffect: MonoBehaviour
{

    public List<GameObject> items = new List<GameObject>();
    public GameObject cloud_1;
    public GameObject cloud_2;
    public GameObject cloud_3;
    public GameObject cloud_4;
    public GameObject cloud_5;

    public float fadeTime = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //CloudMove();
        //StartCoroutine("BoomEffect");
    }


    //버튼 이펙트
    IEnumerator BoomEffect()
    {
        foreach (var item in items)
        {
            item.transform.localScale = Vector3.zero;
        }
        foreach (var item in items)
        {
            item.transform.DOScale(1f, fadeTime).SetEase(Ease.OutBounce);
            yield return new WaitForSeconds(0.25f);
        }
        //foreach (var button in buttons)
        //{
        //    button.transform.localScale = Vector3.zero;
        //}
    }

    public void BoomEvent()
    {
        StartCoroutine("BoomEffect");
    }


    ////지나가는 구름
    //public void CloudMove()
    //{
    //    //x값으로 200 거리를 2.5초 동안 이동
    //    cloud_1.transform.DOLocalMoveX(1920, 430f).SetEase(Ease.OutBack);
    //    cloud_2.transform.DOLocalMoveX(-1920, 440f).SetEase(Ease.OutBack);
    //    cloud_3.transform.DOLocalMoveX(-1920, 420f).SetEase(Ease.OutBack);
    //    cloud_4.transform.DOLocalMoveX(1920, 450f).SetEase(Ease.OutBack);
    //    cloud_5.transform.DOLocalMoveX(-1920, 480f).SetEase(Ease.OutBack);
    //}


}
