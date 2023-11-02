using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_CountDown : MonoBehaviour
{
    private UI_Timer ui_Timer;

    [SerializeField]
    private GameObject invisible_BackGround;
    [SerializeField]
    private GameObject countDown_Start;
    [SerializeField]
    private GameObject countDown_1;
    [SerializeField]
    private GameObject countDown_2;
    [SerializeField]
    private GameObject countDown_3;

    //Timer
    private bool CountDonw_Check = false;
    private float currentTime = 0;
    private int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        ui_Timer = FindObjectOfType<UI_Timer>();
        SetCountDownOn();
    }

    // Update is called once per frame
    void Update()
    {
        GameStart_CountDown();
    }
    public void SetCountDownOn()
    {
        CountDonw_Check = true;
        GameStart_CountDown();
    }



    public void GameStart_CountDown()
    {
        //mission_CountDown.SetActive(true);
        //mission_CountDown_Bg.SetActive(true);
        if (CountDonw_Check)
        {
            invisible_BackGround.SetActive(true);
            Debug.Log("여기가 타요");
            currentTime += Time.unscaledDeltaTime;
            if (currentTime >= 1)
            {
                countDown_3.SetActive(true);
                if (currentTime >= 2)
                {
                    countDown_3.SetActive(false);
                    countDown_2.SetActive(true);
                    if (currentTime >= 3)
                    {
                        countDown_2.SetActive(false);
                        countDown_1.SetActive(true);
                        if (currentTime > 4)
                        {
                            countDown_1.SetActive(false);
                            countDown_Start.SetActive(true);
                            if (currentTime > 4.5f)
                            {
                                countDown_Start.SetActive(false);
                                invisible_BackGround.SetActive(false);
                                ////카운트다운 후 시간이 흐르도록 변경
                                count++;
                                if (count == 1)
                                {
                                    //GameManager.Instance.StartCoroutine("FlipAllCardRoutine");
                                }
                                ui_Timer.SetTimerOn();
                                Time.timeScale = 1;
                                count = 0;
                                CountDonw_Check = false;
                            }
                        }
                    }
                }
            }
        }
    }
}
