using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    Text timerText;

    bool timerActive;
    float second;
    int min;

    void Start()
    {
        SetTimerOn();
    }

    void Update() // 바뀌는 시간을 text에 반영 해 줄 update 생명주기
    {
        if (timerActive)
        {
            second += Time.deltaTime;
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
    }

}
