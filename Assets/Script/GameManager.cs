using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private List<Card> allCards;
    private List<FindCard> allfindCardList;
    private Card flippedCard;
    private FindCard waitingCard;
    private Board board;
    private LevelManager levelManager;

    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    void Start()
    {
        board = FindObjectOfType<Board>();
        levelManager = FindObjectOfType<LevelManager>();
        allCards = board.GetCards();

        StartCoroutine("FlipAllCardRoutine");
    }

    IEnumerator FlipAllCardRoutine()
    {
        yield return new WaitForSeconds(0.5f);
        FlipAllCard();
        yield return new WaitForSeconds(3f);
    }


    void FlipAllCard()
    {
        foreach(Card card in allCards) 
        {
            card.StartFlipCard();   
        }
    }

    //카드 클릭
    public void CardClicked(Card card)
    {
        card.FlipCard();
        flippedCard = card;
        allfindCardList = board.GetFindCardList();
        waitingCard = allfindCardList[0];

        //FlippedCard = 클릭할 카드, watingCard = 찾아야할 카드
        StartCoroutine(CheckMatchRouttin(flippedCard, waitingCard));

        //게임 상황 체크
        levelManager.GamePlayingCheck();

        flippedCard = null;
    }

    //카드 매치
    IEnumerator CheckMatchRouttin(Card card, FindCard findcard)
    {
        Debug.Log("클릭한 카드 번호" + card.cardID);
        Debug.Log("찾아야할 카드 번호" + findcard.findCardID);
        if (card.cardID == findcard.findCardID)
        {
            Debug.Log("Same Card");
            board.SameCardDestory();
            //찾은 개수 증가
            levelManager.findCount++;
        }
        else
        {
            Debug.Log("Different Card");
            yield return new WaitForSeconds(1f);
            card.FlipCard();
            yield return new WaitForSeconds(0.4f);
        }
        flippedCard = null;
    }
}
