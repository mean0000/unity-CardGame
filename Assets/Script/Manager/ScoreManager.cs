using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public static int time_Score_Easy;
    public static int time_Score_Normal;
    public static int time_Score_Hard;

    public static int forcus_Score_Easy;
    public static int forcus_Score_Normal;
    public static int forcus_Score_Hard;

    public static int memory_Score_Easy;
    public static int memory_Score_Normal;
    public static int memory_Score_Hard;


    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void init()
    {
        time_Score_Easy = 0;
        time_Score_Normal = 0;
        time_Score_Hard = 0;

        forcus_Score_Easy = 0;
        forcus_Score_Normal = 0;
        forcus_Score_Hard = 0;

        memory_Score_Easy = 0;
        memory_Score_Normal = 0;
        memory_Score_Hard = 0;
    }

    //순발력 - 단계 클리어 시간
    //레벨에 따라 값 분열이 필요할 수 있음..
    public void Time_Score_Save(int score)
    {
        if(LevelManager.mainLevel == 0)
        {
            time_Score_Easy += score;

        }
    }

    //집중력 - 정답을 맞추기까지의 소요시간
    public void Forcus_Score_Save(int score)
    {
        forcus_Score_Easy += score;
    }

    //기억력- 틀린 횟수
    public void Memory_Score_Save()
    {
        memory_Score_Easy += 1;
    }


}
