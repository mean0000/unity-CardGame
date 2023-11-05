using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public static int time_Score;
    public static int forcus_Score;


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
        time_Score = 0;
        forcus_Score = 0;
    }

    public void ForcusScore_Save()
    {
        forcus_Score += forcus_Score;
    }

    public void Time_Score_Save(int score)
    {
        time_Score += score;
    }
}
