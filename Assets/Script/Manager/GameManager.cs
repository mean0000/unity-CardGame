using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private Card flippedCard;
    private FindCard waitingCard;
    
    private List<Card> allCards;
    private List<FindCard> allfindCardList;
    public bool isFlipping = false;


    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        allCards = Board.instance.GetCards();

        StartCoroutine("FlipAllCardRoutine");
    }

    IEnumerator FlipAllCardRoutine()
    {
        isFlipping = true;
        yield return new WaitForSeconds(0.5f);
        FlipAllCard();
        yield return new WaitForSeconds(1f);
        isFlipping = false;
    }


    public void FlipAllCard()
    {
        foreach(Card card in allCards) 
        {
            Debug.Log("여기가 시작 뒤집기");
            card.StartFlipCard();
        }
    }

    //카드 클릭
    public void CardClicked(Card card)
    {
        //카드 뒤집기 방지
        if (isFlipping)
        {
            return;
        }


        card.FlipCard();
        flippedCard = card;
        allfindCardList = Board.instance.GetFindCardList();
        waitingCard = allfindCardList[0];

        //FlippedCard = 클릭할 카드, watingCard = 찾아야할 카드
        StartCoroutine(CheckMatchRouttin(flippedCard, waitingCard));

        flippedCard = null;
    }

    //카드 매치
    IEnumerator CheckMatchRouttin(Card card, FindCard findcard)
    {
        Debug.Log("클릭한 카드 번호" + card.cardID);
        Debug.Log("찾아야할 카드 번호" + findcard.findCardID);

        bool card_Matching_Result = false;

        isFlipping = true;



        if (Board.instance.resetCheck)
        {
            card.CardReStart();
        }


        if (card.cardID == findcard.findCardID)
        {
            card.SetMatched();
            Debug.Log("Same Card");
            //찾은 개수 증가
            LevelManager.Instance.findCount++;

            //카드 삭제
            Board.instance.SameCardDestory();
            Debug.Log("카드 제거");

            //카드 맞추기 성공
            yield return new WaitForSeconds(0.25f);
            Debug.Log("팝업 등장");
            card_Matching_Result = true;
            Board.instance.CardMatchingResultPopup(card_Matching_Result);
            yield return new WaitForSeconds(0.8f);
        }
        else
        {
            Debug.Log("Different Card");

            //카드 맞추기 실패
            yield return new WaitForSeconds(0.3f);
            card_Matching_Result = false;
            Board.instance.CardMatchingResultPopup(card_Matching_Result);

            yield return new WaitForSeconds(1f);
            card.FlipCard();

            yield return new WaitForSeconds(0.8f);

        }

        isFlipping = false;
        flippedCard = null;


        //게임 상황 체크
        LevelManager.Instance.GamePlayingCheck();
    }


}
