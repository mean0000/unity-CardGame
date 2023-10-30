﻿using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Board board;

    public string leveltext;
    public int mainLevel; //게임 메인 레벨(쉬움, 보통, 어려움)
    public int subLevel; //게임 서브 레벨 (쉬움 1단계, 쉬움 2단계, ... 총 5단계까지 )
    public int findCount; //찾은 개수
    public int targetCount; // 목표 개수
    public int targetCardCount_Card; // 찾아야 할 화투패 위 개수

    [SerializeField]
    private GameObject gameFinishPopup;
    [SerializeField]
    private GameObject gameSelect;
    [SerializeField]
    private GameObject gamePlay;


    public void Level_Easy()
    {
        // 처음 단계 시작시 mainLevel = 1, subLevel = 1 로 시작
        //그 이후 단계 선택 없이 sublevel에 +1 하여 진행
        //subLevel = 5가 되었을 때, 해당 단계는 마무리
        Debug.Log("레벨 선택" + subLevel);
        Debug.Log("레벨 선택" + mainLevel);

        if (gameSelect.activeSelf)
        {
            Debug.Log("레벨 선택@@@@@@@");
            mainLevel = 1;
            subLevel = 1;
        }
        else
        {
            Debug.Log("난이도 선택 화면이 아님");
        }


        gamePlay.SetActive(true);
        Debug.Log("sublevel:" + subLevel);

        if (mainLevel == 1 && subLevel == 1) 
        {
            //보드 카드 오브젝트 생성 수
            targetCount = 3;
            targetCardCount_Card = targetCount;

            Debug.Log("레벨 선택 메소드");
            leveltext = "쉬움 - 1단계";

            subLevel = +1;
            GameSelect_Obejct_Off();
        }
        else if(mainLevel == 1 && subLevel == 2)
        {
            targetCount = 5;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 2단계";

            subLevel = +1;
        }
        else if(mainLevel == 1 && subLevel == 3)
        {   
            targetCount = 7;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 3단계";

            subLevel = +1;
        }
        else if(mainLevel == 1 && subLevel == 4) 
        {   
            targetCount = 9;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 4단계";

            subLevel = +1;
        }
        else if(mainLevel == 1 && subLevel == 5)
        {
            targetCount = 11;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 5단계";
        }
    }

    public void Level_Normal()
    {
        mainLevel = 1;
        subLevel = 1;

        if (mainLevel == 2 && subLevel == 1)
        {
            targetCount = 3;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 1단계";

            GameSelect_Obejct_Off();
        }
        else if (mainLevel == 2 && subLevel == 2)
        {
            targetCount = 5;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 2단계";
        }
        else if (mainLevel == 2 && subLevel == 3)
        {
            targetCount = 7;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 3단계";
        }
        else if (mainLevel == 2 && subLevel == 4)
        {
            targetCount = 9;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 4단계";
        }
        else if (mainLevel == 2 && subLevel == 5)
        {
            targetCount = 11;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 5단계";
        }
    }

    public void Level_Hard()
    {
        mainLevel = 1;
        subLevel = 1;

        if (mainLevel == 3 && subLevel == 1)
        {
            targetCount = 3;
            targetCardCount_Card = targetCount;

            GameSelect_Obejct_Off();

            leveltext = "어려움 - 1단계";
        }
        else if (mainLevel == 3 && subLevel == 2)
        {
            targetCount = 5;
            targetCardCount_Card = targetCount;

            leveltext = "어려움 - 2단계";
        }
        else if (mainLevel == 3 && subLevel == 3)
        {
            targetCount = 7;
            targetCardCount_Card = targetCount;

            leveltext = "어려움 - 3단계";
        }
        else if (mainLevel == 3 && subLevel == 4)
        {
            targetCount = 9;
            targetCardCount_Card = targetCount;

            leveltext = "어려움 - 4단계";
        }
        else if (mainLevel == 3 && subLevel == 5)
        {
            targetCount = 11;
            targetCardCount_Card = targetCount;

            leveltext = "어려움 - 5단계";
        }
    }

    //게임 플레이 중 완료와 도중 종료를 체크
    public void GamePlayingCheck()
    {
        Debug.Log("라운드 점수 체크 중 목표 카드:" + targetCount);
        Debug.Log("라운드 점수 체크 중 찾은 카드:" + findCount);
        if (findCount == targetCount)
        {
            Debug.Log("라운드 종료");
            subLevel = +1;
            GameManager.Instance.isFlipping = true;
            gameFinishPopup.SetActive(true);
        }
    }


    public void Restart()
    {
        board = FindObjectOfType<Board>();

        Debug.Log("어디까지");

        if(mainLevel == 1)
        {
            Debug.Log("가는지");
            Level_Easy();
        }
        else if(mainLevel == 2)
        {
            Level_Normal();
        }
        else if(mainLevel == 3)
        {
            Level_Hard();
        }

        subLevel--;

        //board.Restart();
        gameFinishPopup.SetActive(false);
        GameManager.Instance.isFlipping = false;
    }


    public void NextLevel()
    {
        board = FindObjectOfType<Board>();

        if (mainLevel == 1)
        {
            Level_Easy();
        }
        else if (mainLevel == 2)
        {
            Level_Normal();
        }
        else if (mainLevel == 3)
        {
            Level_Hard();
        }

        //board.Restart();
        gameFinishPopup.SetActive(false);
        GameManager.Instance.isFlipping = false;
    }

    private void GameSelect_Obejct_Off()
    {
        gameSelect.SetActive(false);
    }
}