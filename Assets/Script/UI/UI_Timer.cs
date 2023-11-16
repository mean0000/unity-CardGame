using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Timer : MonoBehaviour
{
    public static UI_Timer instance;

    [SerializeField]
    Text timerText;

    public bool timerActive;
    public bool timeCheck;
    public float second;
    public float second_Score;
    int min;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

    }

    void Update() // 바뀌는 시간을 text에 반영 해 줄 update 생명주기
    {
        if (timerActive)
        {
            second += Time.deltaTime;
            second_Score += Time.deltaTime;
            if(second >= 60f)
            {
                min += 1;
                second = 0;
            }
            timerText.text = string.Format("{0:D2}  {1:D2}", min, (int)second);
        }
    }

    public void SetTimerOn()
    {
        timerActive = true;
    }

    public void SetTimerOff()
    {
        timerActive = false;
        ScoreManager.instance.Time_Score_Save((int)second);
    }

    public void Init()
    {
        second = 0;
        min = 0;

    }
    //집중력 체크
    public void Forcus_Scroecheck()
    {
        Debug.Log("second:::" + (int)second_Score);
        ScoreManager.instance.Forcus_Score_Save((int)second_Score);
        second_Score = 0;
    }

}
