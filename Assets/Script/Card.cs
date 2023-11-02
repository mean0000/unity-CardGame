using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Card : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer cardRenderer;

    [SerializeField]
    private Sprite frontSprite;

    [SerializeField]
    private Sprite backSprite;

    
    //카드 뒤집기 체크
    private bool isFlipped = false;
    //카드가 뒤집히고 있는지 체크
    private bool isFlipping = false;
    //시작 카드 뒤집기 체크
    private bool startFlipCheck = false;
    //카드 매치 확인
    private bool isMatched = false;

    public int cardID;
    //public int findCardID;



    public void SetCardID(int id)
    { 
        cardID = id; 
    }

    public void SetMatched() 
    { 
        isMatched = true;
    }
    
    //카드 이미지 변경
    public void SetFrontSprite(Sprite sprite)
    {
        frontSprite = sprite;
        cardRenderer.sprite = backSprite;
    }

    //카드 뒤집기 이펙트
    public void FlipCard()
    {
        Debug.Log("FlipCard");
        isFlipping = true;
        //최초의 값
        Vector3 originalScale = transform.localScale;
        //타겟의 x값 조절을 위해 x값만 변경, y값, z값은 originalScale 값을 가져값
        Vector3 targetScale = new Vector3(0f, originalScale.y, originalScale.z);

        //카드 뒤집는 작업
        //trasnform.DoScale(변경이 되기를 원하는 결과, 변하는 시간)
        //c#문법 .OnComplete (() => {}); .앞의 계산이 끝났을 때 onComplete 뒤의 중가로의 작업 진행됨
        transform.DOScale(targetScale, 0.2f).OnComplete(() =>
        {
            isFlipped = !isFlipped;

            //시작 화면 첫 뒤집기 이미지 변경
            if (startFlipCheck)
            {
                
                if (isFlipped)
                {
                    
                    cardRenderer.sprite = frontSprite;
                }
                else
                {
                    
                    cardRenderer.sprite = backSprite;
                }
                startFlipCheck = false;

                transform.DOScale(originalScale, 0.2f).OnComplete(() =>
                {
                    isFlipping = false;
                });
                return;
            }
            Debug.Log("스타트");
            //그 이후 카드 뒤집기 이미지 변경
            if (isFlipped)
            {
                Debug.Log("앞");
                cardRenderer.sprite = frontSprite;
            }
            else
            {
                Debug.Log("뒤");
                cardRenderer.sprite = backSprite;
            }

            //뒤집은 카드를 다시 뒤집는 작업
            transform.DOScale(originalScale, 0.2f).OnComplete(() =>
            {
                isFlipping = false;
            });
        });
        Debug.Log("FlipCard_End");
    }

    //시작 시 카드 뒤집기 이펙트 메소드
    public void StartFlipCard()
    {
        isFlipping = true;
        Vector3 originalScale = transform.localScale;
        Vector3 targetScale = new Vector3(0f, originalScale.y, originalScale.z);

        transform.DOScale(targetScale, 0.2f).OnComplete(() =>
        {
            isFlipped = !isFlipped;

            if (isFlipped)
            {
                cardRenderer.sprite = frontSprite;
            }
            else
            {
                cardRenderer.sprite = backSprite;
            }

            transform.DOScale(originalScale, 0.2f).OnComplete(() =>
            {
                isFlipping = false;
            });
        });
    }

    public void CardReStart()
    {
        startFlipCheck = true;
    }


    //카드 클릭
    private void OnMouseDown()
    {
        if (!isFlipping  && !isMatched)
        {
            //FlipCard();
            Debug.Log("카드 뒤집는다");
            GameManager.Instance.CardClicked(this);
        }
    }
}
