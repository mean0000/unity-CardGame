using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public static Board instance;
    //private CardSelectEffect cardSelectEffect;
    private UI_CountDown ui_CountDown;
    private UI_Timer ui_Timer;

    [SerializeField]
    private GameObject cardPrefab;
    [SerializeField]
    private Sprite[] cardSprite;

    [SerializeField]
    private GameObject findCardPrefab;
    [SerializeField]
    private Sprite[] findCardSprite;


    [SerializeField]
    public GameObject card_Matching_Success00;
    [SerializeField]
    public GameObject card_Matching_Success01;
    [SerializeField]
    public GameObject card_Matching_Mistake00;
    [SerializeField]
    public GameObject card_Matching_Mistake01;

    private GameObject cardObject;
    private GameObject FindCardObject;

    private List<Card> cardList = new List<Card>();
    private List<FindCard> findCardList = new List<FindCard>();

    private List<int> cardIDList = new List<int>();
    private List<GameObject> CardObjectList = new List<GameObject>();

    private List<int> findCardIDList = new List<int>();
    private List<GameObject> findCardObjectList = new List<GameObject>();

    private int index = 0;
    private int deleteIndex = 0;
    private int objectIndex = 1;

    public static bool resetCheck = false;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        //cardSelectEffect = FindObjectOfType<CardSelectEffect>();
        ui_CountDown = FindObjectOfType<UI_CountDown>();

        Debug.Log("확인");

        ui_CountDown.SetCountDownOn();

        GenerateCardID();

        ShuffleCardID();
        ShuffleFindCardID();

        try
        {
            InitBoard();
            InitFindBoard();
        }
        catch
        {
            Debug.Log("Start_아직 게임 시작 화면이 아님");
        };
    }

    public void Restart()
    {
        resetCheck = true;
    }

    //카드 생성
    void GenerateCardID()
    {
        for(int i = 0; i < cardSprite.Length; i++) 
        {
            cardIDList.Add(i);
        }

        for (int i = 0; i < findCardSprite.Length; i++)
        {
            findCardIDList.Add(i);
        }
    }

    //카드 섞기
    void ShuffleCardID()
    {
        int cardCount = cardIDList.Count;
        for(int i = 0; i< cardCount; i++)
        {
            int randomIndex = UnityEngine.Random.Range(i, cardCount);
            int temp = cardIDList[randomIndex];
            cardIDList[randomIndex] = cardIDList[i];
            cardIDList[i] = temp;
        }
    }

    void ShuffleFindCardID()
    {
        int findCardCount = findCardIDList.Count;
        for (int i = 0; i < findCardCount; i++)
        {
            int randomIndex = UnityEngine.Random.Range(i, findCardCount);
            int temp = findCardIDList[randomIndex];
            findCardIDList[randomIndex] = findCardIDList[i];
            findCardIDList[i] = temp;
        }
    }

    //보드 초기화 후 카드 생성 (추후 중앙 정렬 필요)
    void InitBoard()
    {
        GameObject cardGather = GameObject.Find("CardGather");

        //각 축 간격 (x: 1.1f, y:1.6f)
        float spaceY = -1.6f;
        float spaceX = 1.1f;

        //세로 크기
        int rowCount = 5;
        //가로 크기
        int colCount = 10;
        //카드 인덱스
        int cardIndex = 0;

        if (resetCheck)
        {
            Debug.Log("오류가 여기서" + CardObjectList.Count);
            for (int i = 0; i < 48; i++)
            {
                Debug.Log("i의 값: " + i);
                //CardObjectList.RemoveAt(i);
                Destroy(CardObjectList[i]);
            }

            for (int i = CardObjectList.Count - 1; i >= 0; i--)
            {
                CardObjectList.Remove(CardObjectList[i]);
            }
        }

        //배치 
        for (int row = 0; row < rowCount; row++)
        {
            for (int col = 0; col < colCount; col++)
            {
                //각 X와 Y좌표
                //posX의 경우 중앙에 맞추기 위해 -1 값 추가
                float posX = (col - (colCount / 2)) * spaceX - 1;
                float posY = (row - (int)(rowCount / 2)) * spaceY;
                Vector3 pos = new Vector3(posX, posY, 0f);
                //Instantiate: 이미 만들어진 오브젝트를 실시간으로 만듬 Instantiate(오브젝트, 위치, 회전값);
                cardObject = Instantiate(cardPrefab, pos, Quaternion.identity);

                cardObject.transform.SetParent(cardGather.transform);
                CardObjectList.Add(cardObject);

                Card card = cardObject.GetComponent<Card>();
                int cardID = cardIDList[cardIndex++];
                card.SetCardID(cardID);
                card.SetFrontSprite(cardSprite[cardID]);
                cardList.Add(card);


                if (cardIndex >= 48)
                {
                    return;
                }
            }
        }
    }

    //보드 초기화 후 찾아야할 카드 생성
    void InitFindBoard()
    {
        Debug.Log("오류 확인" + LevelManager.targetCardCount_Card);
        int findcardCount = LevelManager.targetCardCount_Card;
        Debug.Log("찾아야할 카드 개수: " + findcardCount);
        int findCardIndex = 0;

        for (int count = 0; count < findcardCount; count++)
        {
            Vector3 pos = new Vector3(6.06f, -1.62f, 0f);
            FindCardObject = Instantiate(findCardPrefab, pos, Quaternion.identity);
            FindCard findCard = FindCardObject.GetComponent<FindCard>();

            int findCardID = findCardIDList[findCardIndex++];
            findCardObjectList.Add(FindCardObject);
            findCardObjectList[index++].SetActive(false);

            findCard.SetFindCardID(findCardID);
            findCard.SetFrontSprite(cardSprite[findCardID]);
            findCardList.Add(findCard);
        }


        Debug.Log("오류 확인 리스트 체크" + findCardObjectList.Count);
        if(resetCheck == false)
        {
            findCardObjectList[0].SetActive(true);

        }else if(resetCheck == true)
        {
            findCardObjectList[3].SetActive(true);
        }
    }
    
    //오브젝트 제거
    public void SameCardDestory()
    {
        Destroy(findCardObjectList[deleteIndex++]);
        //리스트가 계속 0번째로 갱신되어 0번 리스트만 계속 삭제
        findCardList.RemoveAt(0);
        //findCardObjectList.RemoveAt(deleteIndex);
        try
        {
            findCardObjectList[objectIndex++].SetActive(true);
        }catch(ArgumentOutOfRangeException e)
        {
            Debug.Log(e.Message);
        }
    }


    public List<Card> GetCards()
    {
        return cardList;
    }

    public List<FindCard> GetFindCardList()
    {
        return findCardList;
    }




    //카드 매칭 성공 실패 팝업
    public void CardMatchingResultPopup(bool check)
    {
        int popupDivNum = 0;
        int randomIndex = UnityEngine.Random.Range(0, 2);
        Vector3 originalScale = transform.localScale;
        Debug.Log("Random00: " + randomIndex);
        Debug.Log("check" + check);
        if (check)
        {
            if (randomIndex == 0)
            {
                popupDivNum = 0;

                //cardSelectEffect.CardClicking(popupDivNum);
                card_Matching_Success00.SetActive(true);
                EffectManager.Instance.flowEffect.BoomEvent();
                transform.DOScale(originalScale, 1f).OnComplete(() =>
                {
                    card_Matching_Success00.SetActive(false);
                });
            }
            else
            {
                popupDivNum = 1;

                //cardSelectEffect.CardClicking(popupDivNum);
                card_Matching_Success01.SetActive(true);
                EffectManager.Instance.flowEffect.BoomEvent();
                //팝업제거
                transform.DOScale(originalScale, 1f).OnComplete(() =>
                {
                    card_Matching_Success01.SetActive(false);
                });
            }

        }
        else
        {
            if (randomIndex == 0)
            {
                popupDivNum = 2;

                //cardSelectEffect.CardClicking(popupDivNum);
                card_Matching_Mistake00.SetActive(true);

                transform.DOScale(originalScale, 1f).OnComplete(() =>
                {
                    card_Matching_Mistake00.SetActive(false);
                });
            }
            else
            {
                popupDivNum = 3;

                //cardSelectEffect.CardClicking(popupDivNum);
                card_Matching_Mistake01.SetActive(true);

                transform.DOScale(originalScale, 1f).OnComplete(() =>
                {
                    card_Matching_Mistake01.SetActive(false);
                });
            }

        }

    }




}
