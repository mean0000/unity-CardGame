using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    [SerializeField]
    private UI_Timer ui_Timer;
    [SerializeField]
    private UI_CountDown ui_CountDown;

    public string leveltext;
    public static int mainLevel; //게임 메인 레벨(쉬움, 보통, 어려움)
    public static int subLevel; //게임 서브 레벨 (쉬움 1단계, 쉬움 2단계, ... 총 5단계까지 )
    public static int findCount; //찾은 개수
    public static int targetCount; // 목표 개수
    public static int targetCardCount_Card; // 찾아야 할 화투패 위 개수

    [SerializeField]
    private GameObject gameFinishPopup;
    [SerializeField]
    private GameObject gameSelect;
    [SerializeField]
    private GameObject gamePlay;


    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }

        if (Board.resetCheck)
        {
            gameSelect.SetActive(false);
        }
    }

    public void Level_Easy()
    {
        // 처음 단계 시작시 mainLevel = 1, subLevel = 1 로 시작
        //그 이후 단계 선택 없이 sublevel에 +1 하여 진행
        //subLevel = 5가 되었을 때, 해당 단계는 마무리
        Debug.Log("레벨 선택" + subLevel);
        Debug.Log("레벨 선택" + mainLevel);

        //if (gameSelect.activeSelf)
        //{
        //    mainLevel = 1;
        //    subLevel = 1;
        //    Debug.Log("난이도 선택 화면!!");
        //}
        //else
        //{
        //    Debug.Log("난이도 선택 화면이 아님");
        //}

        //gamePlay.SetActive(true);
        Debug.Log("sublevel:" + subLevel);
        //subLevel = 4;

        if (mainLevel == 0 && subLevel == 0) 
        {
            //보드 카드 오브젝트 생성 수
            targetCount = 3;
            targetCardCount_Card = targetCount;

            Debug.Log("레벨 선택 메소드 sublevel" + subLevel);
            leveltext = "쉬움 - 1단계";

            Debug.Log("sublevel 업" + subLevel);
            //GameSelect_Obejct_Off();
        }
        else if(mainLevel == 0 && subLevel == 1)
        {
            targetCount = 5;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 2단계";
        }
        else if(mainLevel == 0 && subLevel == 2)
        {   
            targetCount = 7;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 3단계";
        }
        else if(mainLevel == 0 && subLevel == 3) 
        {   
            targetCount = 9;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 4단계";
        }
        else if(mainLevel == 0 && subLevel == 4)
        {
            targetCount = 11;
            targetCardCount_Card = targetCount;

            leveltext = "쉬움 - 5단계";
        }
        SceneManager.LoadScene("01_PlayGame");
    }

    public void Level_Normal()
    {
        //mainLevel = 1;
        //subLevel = 1;

        if (mainLevel == 1 && subLevel == 0)
        {
            targetCount = 3;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 1단계";

            //GameSelect_Obejct_Off();
        }
        else if (mainLevel == 1 && subLevel == 1)
        {
            targetCount = 5;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 2단계";
        }
        else if (mainLevel == 1 && subLevel == 2)
        {
            targetCount = 7;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 3단계";
        }
        else if (mainLevel == 1 && subLevel == 3)
        {
            targetCount = 9;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 4단계";
        }
        else if (mainLevel == 1 && subLevel == 4)
        {
            targetCount = 11;
            targetCardCount_Card = targetCount;

            leveltext = "보통 - 5단계";
        }
        SceneManager.LoadScene("01_PlayGame");
    }

    public void Level_Hard()
    {
        //mainLevel = 1;
        //subLevel = 1;

        if (mainLevel == 3 && subLevel == 1)
        {
            targetCount = 3;
            targetCardCount_Card = targetCount;

            //GameSelect_Obejct_Off();

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
        SceneManager.LoadScene("01_PlayGame");
    }

    //게임 플레이 중 완료와 도중 종료를 체크
    public void GamePlayingCheck()
    {
        Debug.Log("라운드 점수 체크 중 목표 카드:" + targetCount);
        Debug.Log("라운드 점수 체크 중 찾은 카드:" + findCount);
        if (findCount == targetCount)
        {
            Debug.Log("라운드 종료");

            GameManager.Instance.isFlipping = true;
            
            //이펙트
            if(subLevel <= 3)
            {
                EffectManager.Instance.popupEffect.PanelFadeIn();
            }else if(subLevel == 4)
            {
                EffectManager.Instance.popupEffect.PanelFadeIn_Rusult();
            }
            EffectManager.Instance.ui_confettiEffect_L.Show();
            EffectManager.Instance.ui_confettiEffect_R.Show();

            //타이머 종료
            ui_Timer.SetTimerOff();

        }
    }


    public void Restart()
    {
        Debug.Log("재시작");

        findCount = 0;

        //ui_Timer.Init();
        //gameFinishPopup.SetActive(false);
        //GameManager.Instance.isFlipping = false;

        if (mainLevel == 0)
        {
            Level_Easy();
        }
        else if (mainLevel == 1)
        {
            Level_Normal();
        }
        else if (mainLevel == 2)
        {
            Level_Hard();
        }

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }


    public void NextLevel()
    {
        Debug.Log("다음 레벨");
        Debug.Log("다음 레벨 sublevel 체크" + subLevel);

        //ui_Timer.Init();
        findCount = 0;
        subLevel += 1;
        Debug.Log("다음 레벨 sublevel 체크" + subLevel);

        //Board.instance.Restart();
        //gameFinishPopup.SetActive(false);

        GameManager.Instance.isFlipping = false;

        if (mainLevel == 0)
        {
            Level_Easy();
        }
        else if (mainLevel == 1)
        {
            Level_Normal();
        }
        else if (mainLevel == 2)
        {
            Level_Hard();
        }

    }
}
