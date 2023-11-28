using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public static int all_Time_Score_Easy;
    public static int all_Time_Score_Normal;
    public static int all_Time_Score_Hard;

    public static int all_Forcus_Score_Easy;
    public static int all_Forcus_Score_Normal;
    public static int all_Forcus_Score_Hard;

    public static int all_Memory_Score_Easy;
    public static int all_Memory_Score_Normal;
    public static int all_Memory_Score_Hard;

    //순발력 값
    int sub1_Score_Easy = 0;
    int sub2_Score_Easy = 0;
    int sub3_Score_Easy = 0;
    int sub4_Score_Easy = 0;
    int sub5_Score_Easy = 0;
    int final_Score_Easy = 0;

    int sub1_Score_Normal = 0;
    int sub2_Score_Normal = 0;
    int sub3_Score_Normal = 0;
    int sub4_Score_Normal = 0;
    int sub5_Score_Normal = 0;
    int final_Score_Normal = 0;

    int sub1_Score_Hard = 0;
    int sub2_Score_Hard = 0;
    int sub3_Score_Hard = 0;
    int sub4_Score_Hard = 0;
    int sub5_Score_Hard = 0;
    int final_Score_Hard = 0;

    //집중력 값
    int sub1_Forcus_Easy = 0;
    int sub2_Forcus_Easy = 0;
    int sub3_Forcus_Easy = 0;
    int sub4_Forcus_Easy = 0;
    int sub5_Forcus_Easy = 0;
    int final_Forcus_Easy = 0;

    int sub1_Forcus_Normal = 0;
    int sub2_Forcus_Normal = 0;
    int sub3_Forcus_Normal = 0;
    int sub4_Forcus_Normal = 0;
    int sub5_Forcus_Normal = 0;
    int final_Forcus_Normal = 0;

    int sub1_Forcus_Hard = 0;
    int sub2_Forcus_Hard = 0;
    int sub3_Forcus_Hard = 0;
    int sub4_Forcus_Hard = 0;
    int sub5_Forcus_Hard = 0;
    int final_Forcus_Hard = 0;

    //기억력 값
    int sub1_Memory_Easy = 0;
    int sub2_Memory_Easy = 0;
    int sub3_Memory_Easy = 0;
    int sub4_Memory_Easy = 0;
    int sub5_Memory_Easy = 0;
    int final_Memory_Easy = 0;

    int sub1_Memory_Normal = 0;
    int sub2_Memory_Normal = 0;
    int sub3_Memory_Normal = 0;
    int sub4_Memory_Normal = 0;
    int sub5_Memory_Normal = 0;
    int final_Memory_Normal = 0;

    int sub1_Memory_Hard = 0;
    int sub2_Memory_Hard = 0;
    int sub3_Memory_Hard = 0;
    int sub4_Memory_Hard = 0;
    int sub5_Memory_Hard = 0;
    int final_Memory_Hard = 0;

    int temp_Memory = 0;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void init()
    {
        all_Time_Score_Easy = 0;
        all_Time_Score_Normal = 0;
        all_Time_Score_Hard = 0;

        all_Forcus_Score_Easy = 0;
        all_Forcus_Score_Normal = 0;
        all_Forcus_Score_Hard = 0;

        all_Memory_Score_Easy = 0;
        all_Memory_Score_Normal = 0;
        all_Memory_Score_Hard = 0;
    }


    // ████████████████████████████████████████████████████   순발력 - 단계 클리어 시간   ████████████████████████████████████████████████████
    public void Time_Score_Save(int score)
    {
        /// <----------------------------------------------   쉬움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 0)
        {
            if(LevelManager.subLevel == 0)
            {
                sub1_Score_Easy = 0;
                sub1_Score_Easy += score;
                //Debug.Log("서브 점수_1::" + sub1_Score_Easy);
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Score_Easy = 0;
                sub2_Score_Easy += score;
                //Debug.Log("서브 점수_2::" + sub2_Score_Easy);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Score_Easy = 0;
                sub3_Score_Easy += score;
                //Debug.Log("서브 점수_3::" + sub3_Score_Easy);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Score_Easy = 0;
                sub4_Score_Easy += score;
                //Debug.Log("서브 점수_4::" + sub4_Score_Easy);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Score_Easy = 0;
                sub5_Score_Easy += score;
                //Debug.Log("서브 점수_5::" + sub5_Score_Easy);
            }
            final_Score_Easy = sub1_Score_Easy + sub2_Score_Easy + sub3_Score_Easy + sub4_Score_Easy + sub5_Score_Easy;
            //Debug.Log("중간 정산 점수:::" + final_Score_Easy);
        }


        /// <----------------------------------------------   보통 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 1)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Score_Normal = 0;
                sub1_Score_Normal += score;
                //Debug.Log("서브 점수_1::" + sub1_Score_Normal);
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Score_Normal = 0;
                sub2_Score_Normal += score;
                //Debug.Log("서브 점수_2::" + sub2_Score_Normal);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Score_Normal = 0;
                sub3_Score_Normal += score;
                //Debug.Log("서브 점수_3::" + sub3_Score_Normal);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Score_Normal = 0;
                sub4_Score_Normal += score;
                //Debug.Log("서브 점수_4::" + sub4_Score_Normal);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Score_Normal = 0;
                sub5_Score_Normal += score;
                //Debug.Log("서브 점수_5::" + sub5_Score_Normal);
            }
            final_Score_Normal = sub1_Score_Normal + sub2_Score_Normal + sub3_Score_Normal + sub4_Score_Normal + sub5_Score_Normal;
            //Debug.Log("중간 정산 점수:::" + final_Score_Normal);
        }


        /// <----------------------------------------------   어려움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 2)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Score_Hard = 0;
                sub1_Score_Hard += score;
                //Debug.Log("서브 점수_1::" + sub1_Score_Hard);
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Score_Hard = 0;
                sub2_Score_Hard += score;
                //Debug.Log("서브 점수_2::" + sub2_Score_Hard);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Score_Hard = 0;
                sub3_Score_Hard += score;
                //Debug.Log("서브 점수_3::" + sub3_Score_Hard);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Score_Hard = 0;
                sub4_Score_Hard += score;
                //Debug.Log("서브 점수_4::" + sub4_Score_Hard);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Score_Hard = 0;
                sub5_Score_Hard += score;
                //Debug.Log("서브 점수_5::" + sub5_Score_Hard);
            }
            final_Score_Hard = sub1_Score_Hard + sub2_Score_Hard + sub3_Score_Hard + sub4_Score_Hard + sub5_Score_Hard;
            Debug.Log("중간 정산 점수:::" + final_Score_Hard);
        }

        All_Time_Score();
    }


    //████████████████████████████████████████████████████   순발력 - 재 시 작   ████████████████████████████████████████████████████
    public void Restrat_Time_Score(int score)
    {
        /// <----------------------------------------------   쉬움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 0)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Time_Score_Easy -= (sub1_Score_Easy += score);
                //Debug.Log("재시작 서브 점수_1::" + time_Score_Easy);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Time_Score_Easy -= (sub2_Score_Easy += score);
                //Debug.Log("재시작 서브 점수_2::" + time_Score_Easy);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Time_Score_Easy -= (sub3_Score_Easy += score);
                //Debug.Log("재시작 서브 점수_3::" + time_Score_Easy);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Time_Score_Easy -= (sub4_Score_Easy += score);
                //Debug.Log("재시작 서브 점수_4::" + time_Score_Easy);
            }
            if (LevelManager.subLevel == 4)
            {
                all_Time_Score_Easy -= (sub5_Score_Easy += score);
                //Debug.Log("재시작 서브 점수_5::" + time_Score_Easy);
            }
        }

        /// <----------------------------------------------   보통 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 1)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Time_Score_Normal -= (sub1_Score_Normal += score);
                //Debug.Log("재시작 서브 점수_1::" + time_Score_Normal);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Time_Score_Normal -= (sub2_Score_Normal += score);
                //Debug.Log("재시작 서브 점수_2::" + time_Score_Normal);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Time_Score_Normal -= (sub3_Score_Normal += score);
                //Debug.Log("재시작 서브 점수_3::" + time_Score_Normal);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Time_Score_Normal -= (sub4_Score_Normal += score);
                //Debug.Log("재시작 서브 점수_4::" + time_Score_Normal);
            }
            if (LevelManager.subLevel == 4)
            {
                all_Time_Score_Normal -= (sub5_Score_Normal += score);
                //Debug.Log("재시작 서브 점수_5::" + time_Score_Normal);
            }
        }


        /// <----------------------------------------------   어려움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 2)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Time_Score_Hard -= (sub1_Score_Hard += score);
                //Debug.Log("재시작 서브 점수_1::" + time_Score_Hard);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Time_Score_Hard -= (sub2_Score_Hard += score);
                //Debug.Log("재시작 서브 점수_2::" + time_Score_Normal);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Time_Score_Hard -= (sub3_Score_Hard += score);
                //Debug.Log("재시작 서브 점수_3::" + time_Score_Normal);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Time_Score_Hard -= (sub4_Score_Hard += score);
                //Debug.Log("재시작 서브 점수_4::" + time_Score_Hard);
            }
            if (LevelManager.subLevel == 4)
            {
                all_Time_Score_Hard -= (sub5_Score_Hard += score);
                //Debug.Log("재시작 서브 점수_5::" + time_Score_Hard);
            }
        }

        All_Time_Score();
    }
    private void All_Time_Score()
    {
        if (LevelManager.mainLevel == 0)
        {
            all_Time_Score_Easy += final_Score_Easy;
            Debug.Log("쉬움 최종 점수:::" + all_Time_Score_Easy);
        }
        else if (LevelManager.mainLevel == 1)
        {
            all_Time_Score_Normal += final_Score_Normal;
            //Debug.Log("보통 최종 점수:::" + time_Score_Normal);
        }
        else if (LevelManager.mainLevel == 2)
        {
            all_Time_Score_Hard += final_Score_Hard;
            //Debug.Log("어려움 최종 점수:::" + time_Score_Hard);
        }
    }


    // ████████████████████████████████████████████████████   집중력 - 정답을 맞추기까지의 소요 시간   ████████████████████████████████████████████████████
    public void Forcus_Score_Save(int score)
    {   
        /// <----------------------------------------------   쉬움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 0)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Forcus_Easy = 0;
                sub1_Forcus_Easy += score;
                //Debug.Log("서브 점수_1::" + sub1_Forcus_Easy);
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Forcus_Easy = 0;
                sub2_Forcus_Easy += score;
                //Debug.Log("서브 점수_2::" + sub2_Forcus_Easy);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Forcus_Easy = 0;
                sub3_Forcus_Easy += score;
                //Debug.Log("서브 점수_3::" + sub3_Forcus_Easy);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Forcus_Easy = 0;
                sub4_Forcus_Easy += score;
                //Debug.Log("서브 점수_4::" + sub4_Forcus_Easy);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Forcus_Easy = 0;
                sub5_Forcus_Easy += score;
                //Debug.Log("서브 점수_5::" + sub5_Forcus_Easy);
            }

            final_Forcus_Easy = sub1_Forcus_Easy + sub2_Forcus_Easy + sub3_Forcus_Easy + sub4_Forcus_Easy + sub5_Forcus_Easy;
            //Debug.Log("중간 정산 점수:::" + final_Forcus_Easy);
        }


        /// <----------------------------------------------   보통 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 1)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Forcus_Normal = 0;
                sub1_Forcus_Normal += score;
                //Debug.Log("서브 점수_1::" + sub1_Forcus_Normal);
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Forcus_Normal = 0;
                sub2_Forcus_Normal += score;
                //Debug.Log("서브 점수_2::" + sub2_Forcus_Normal);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Forcus_Normal = 0;
                sub3_Forcus_Normal += score;
                //Debug.Log("서브 점수_3::" + sub3_Forcus_Normal);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Forcus_Normal = 0;
                sub4_Forcus_Normal += score;
                //Debug.Log("서브 점수_4::" + sub4_Forcus_Normal);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Forcus_Normal = 0;
                sub5_Forcus_Normal += score;
                //Debug.Log("서브 점수_5::" + sub5_Forcus_Normal);
            }

            final_Forcus_Normal = sub1_Forcus_Normal + sub2_Forcus_Normal + sub3_Forcus_Normal + sub4_Forcus_Normal + sub5_Forcus_Normal;
            //Debug.Log("중간 정산 점수:::" + final_Forcus_Normal);
        }


        /// <----------------------------------------------   어려움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 2)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Forcus_Hard = 0;
                sub1_Forcus_Hard += score;
                //Debug.Log("서브 점수_1::" + sub1_Forcus_Hard);
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Forcus_Hard = 0;
                sub2_Forcus_Hard += score;
                //Debug.Log("서브 점수_2::" + sub2_Forcus_Hard);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Forcus_Hard = 0;
                sub3_Forcus_Hard += score;
                //Debug.Log("서브 점수_3::" + sub3_Forcus_Hard);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Forcus_Hard = 0;
                sub4_Forcus_Hard += score;
                //Debug.Log("서브 점수_4::" + sub4_Forcus_Hard);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Forcus_Hard = 0;
                sub5_Forcus_Hard += score;
                //Debug.Log("서브 점수_5::" + sub5_Forcus_Hard);
            }

            final_Forcus_Hard = sub1_Forcus_Hard + sub2_Forcus_Hard + sub3_Forcus_Hard + sub4_Forcus_Hard + sub5_Forcus_Hard;
            //Debug.Log("중간 정산 점수:::" + final_Forcus_Hard);
        }

        All_Forcus_Score();
    }


    //████████████████████████████████████████████████████   집중력 - 재 시 작   ████████████████████████████████████████████████████
    public void Restart_Forcus_Score(int score)
    {
        /// <----------------------------------------------   쉬움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 0)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Forcus_Score_Easy -= (sub1_Forcus_Easy += score) - 2; //2초는 딜레이 차이
                //Debug.Log("재시작 서브 점수_1111::" + all_Forcus_Score_Easy);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Forcus_Score_Easy -= (sub2_Forcus_Easy += score) - 2;
                //Debug.Log("재시작 서브 점수_2::" + all_Forcus_Score_Easy);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Forcus_Score_Easy -= (sub3_Forcus_Easy += score) - 2;
                //Debug.Log("재시작 서브 점수_3::" + all_Forcus_Score_Easy);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Forcus_Score_Easy -= (sub4_Forcus_Easy += score) - 2;
                //Debug.Log("재시작 서브 점수_4::" + all_Forcus_Score_Easy);
            }
            if (LevelManager.subLevel == 4)
            {
                all_Forcus_Score_Easy -= (sub5_Forcus_Easy += score) - 2;
                //Debug.Log("재시작 서브 점수_5::" + all_Forcus_Score_Easy);
            }
        }


        /// <----------------------------------------------   보통 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 1)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Forcus_Score_Normal -= (sub1_Forcus_Normal += score) - 2;
                //Debug.Log("재시작 서브 점수_1111::" + all_Forcus_Score_Normal);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Forcus_Score_Normal -= (sub2_Forcus_Normal += score) - 2;
                //Debug.Log("재시작 서브 점수_2::" + all_Forcus_Score_Normal);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Forcus_Score_Normal -= (sub3_Forcus_Normal += score) - 2;
                //Debug.Log("재시작 서브 점수_3::" + all_Forcus_Score_Normal);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Forcus_Score_Normal -= (sub4_Forcus_Normal += score) - 2;
                //Debug.Log("재시작 서브 점수_4::" + all_Forcus_Score_Normal);
            }
            if (LevelManager.subLevel == 4)
            {
                all_Forcus_Score_Normal -= (sub5_Forcus_Normal += score) - 2;
                //Debug.Log("재시작 서브 점수_5::" + all_Forcus_Score_Normal);
            }
        }


        /// <----------------------------------------------   보통 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 2)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Forcus_Score_Hard -= (sub1_Forcus_Hard += score) - 2;
                //Debug.Log("재시작 서브 점수_1111::" + all_Forcus_Score_Hard);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Forcus_Score_Hard -= (sub2_Forcus_Hard += score) - 2;
                //Debug.Log("재시작 서브 점수_2::" + all_Forcus_Score_Hard);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Forcus_Score_Hard -= (sub3_Forcus_Hard += score) - 2;
                //Debug.Log("재시작 서브 점수_3::" + all_Forcus_Score_Hard);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Forcus_Score_Hard -= (sub4_Forcus_Hard += score) - 2;
                //Debug.Log("재시작 서브 점수_4::" + all_Forcus_Score_Hard);
            }
            if (LevelManager.subLevel == 4)
            {
                all_Forcus_Score_Hard -= (sub5_Forcus_Hard += score) - 2;
                //Debug.Log("재시작 서브 점수_5::" + all_Forcus_Score_Hard);
            }
        }
        All_Forcus_Score();
    }

    private void All_Forcus_Score()
    {
        if (LevelManager.mainLevel == 0)
        {
            all_Forcus_Score_Easy += final_Forcus_Easy;
            //Debug.Log("쉬움 최종 점수:::" + all_Forcus_Score_Easy);
        }
        else if (LevelManager.mainLevel == 1)
        {
            all_Forcus_Score_Normal += final_Forcus_Normal;
            //Debug.Log("보통 최종 점수:::" + time_Score_Normal);ㅉ
        }
        else if (LevelManager.mainLevel == 2)
        {
            all_Forcus_Score_Hard += final_Forcus_Hard;
            //Debug.Log("어려움 최종 점수:::" + time_Score_Hard);
        }
    }


    // ████████████████████████████████████████████████████   기억력- 카드 맞추기 틀린 횟수   ████████████████████████████████████████████████████
    public void Memory_Score_Save()
    {
        /// <----------------------------------------------   쉬움 난이도   ---------------------------------------------->///

        if (LevelManager.mainLevel == 0)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Memory_Easy = 0;
                sub1_Memory_Easy += 1;
                temp_Memory++;
                Debug.Log("sub1_Memory_Easy" + sub1_Memory_Easy);
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Memory_Easy = 0;
                sub2_Memory_Easy += 1;
                temp_Memory++;
                //Debug.Log("서브 점수_2::" + sub2_Forcus_Easy);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Memory_Easy = 0;
                sub3_Memory_Easy += 1;
                temp_Memory++;
                //Debug.Log("서브 점수_3::" + sub3_Forcus_Easy);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Memory_Easy = 0;
                sub4_Memory_Easy += 1;
                temp_Memory++;
                //Debug.Log("서브 점수_4::" + sub4_Forcus_Easy);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Memory_Easy = 0;
                sub5_Memory_Easy += 1;
                temp_Memory++;
                //Debug.Log("서브 점수_5::" + sub5_Forcus_Easy);
            }
            final_Memory_Easy = sub1_Memory_Easy + sub2_Memory_Easy + sub3_Memory_Easy + sub4_Memory_Easy + sub5_Memory_Easy;
        }


        /// <----------------------------------------------   보통 난이도   ---------------------------------------------->///

        if (LevelManager.mainLevel == 1)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Memory_Normal = 0;
                sub1_Memory_Normal += 1;
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Memory_Normal = 0;
                sub2_Memory_Normal += 1;
                //Debug.Log("서브 점수_2::" + sub2_Forcus_Easy);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Memory_Normal = 0;
                sub3_Memory_Normal += 1;
                //Debug.Log("서브 점수_3::" + sub3_Forcus_Easy);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Memory_Normal = 0;
                sub4_Memory_Normal += 1;
                //Debug.Log("서브 점수_4::" + sub4_Forcus_Easy);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Memory_Normal = 0;
                sub5_Memory_Normal += 1;
                //Debug.Log("서브 점수_5::" + sub5_Forcus_Easy);
            }
            final_Memory_Normal = sub1_Memory_Normal + sub2_Memory_Normal + sub3_Memory_Normal + sub3_Memory_Normal + sub4_Memory_Normal;
        }

        /// <----------------------------------------------   어려움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 2)
        {
            if (LevelManager.subLevel == 0)
            {
                sub1_Memory_Hard = 0;
                sub1_Memory_Hard += 1;
            }
            if (LevelManager.subLevel == 1)
            {
                sub2_Memory_Hard = 0;
                sub2_Memory_Hard += 1;
                //Debug.Log("서브 점수_2::" + sub2_Forcus_Easy);
            }
            if (LevelManager.subLevel == 2)
            {
                sub3_Memory_Hard = 0;
                sub3_Memory_Hard += 1;
                //Debug.Log("서브 점수_3::" + sub3_Forcus_Easy);
            }
            if (LevelManager.subLevel == 3)
            {
                sub4_Memory_Hard = 0;
                sub4_Memory_Hard += 1;
                //Debug.Log("서브 점수_4::" + sub4_Forcus_Easy);
            }
            if (LevelManager.subLevel == 4)
            {
                sub5_Memory_Hard = 0;
                sub5_Memory_Hard += 1;
                //Debug.Log("서브 점수_5::" + sub5_Forcus_Easy);
            }
            final_Memory_Hard = sub1_Memory_Hard + sub2_Memory_Hard + sub3_Memory_Hard + sub4_Memory_Hard + sub5_Memory_Hard;
        }

        All_Memory_Score();
    }
    public void Restart_Memory_Score()
    {
        /// <----------------------------------------------   쉬움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 0)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Memory_Score_Easy -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Memory_Score_Easy -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Memory_Score_Easy -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Memory_Score_Easy -= temp_Memory;
            }
            if (LevelManager.subLevel == 4)
            {
                all_Memory_Score_Easy -= temp_Memory;
            }
        }

        /// <----------------------------------------------   보통 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 1)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Memory_Score_Normal -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Memory_Score_Normal -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Memory_Score_Normal -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Memory_Score_Normal -= temp_Memory;
            }
            if (LevelManager.subLevel == 4)
            {
                all_Memory_Score_Normal -= temp_Memory;
            }
        }

        /// <----------------------------------------------   어려움 난이도   ---------------------------------------------->///
        if (LevelManager.mainLevel == 2)
        {
            if (LevelManager.subLevel == 0)
            {
                all_Memory_Score_Hard -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 1)
            {
                all_Memory_Score_Hard -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 2)
            {
                all_Memory_Score_Hard -= temp_Memory;
                Debug.Log("temp_Memory" + temp_Memory);
            }
            if (LevelManager.subLevel == 3)
            {
                all_Memory_Score_Hard -= temp_Memory;
            }
            if (LevelManager.subLevel == 4)
            {
                all_Memory_Score_Hard -= temp_Memory;
            }
        }
    }

    public void All_Memory_Score()
    {
        if (LevelManager.mainLevel == 0)
        {
            Debug.Log("중간 정산 점수:::" + final_Memory_Easy);
            all_Memory_Score_Easy += final_Memory_Easy;
            Debug.Log("쉬움_기억력 최종 점수:::" + all_Memory_Score_Easy);
        }
        else if (LevelManager.mainLevel == 1)
        {
            all_Memory_Score_Normal += final_Memory_Normal;
            //Debug.Log("보통 최종 점수:::" + time_Score_Normal);
        }
        else if (LevelManager.mainLevel == 2)
        {
            all_Memory_Score_Hard += final_Memory_Hard;
            //Debug.Log("어려움 최종 점수:::" + time_Score_Hard);
        }
    }
}
