using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening.Plugins;
using System.Linq;

public class BarChart_Normal : MonoBehaviour
{
    public Bar barPrefab;
    public int[] inputValues = new int[14];
    //List<Bar> bars = new List<Bar>();
    //public string[] lables = new string[14];
    public Color[] colors = new Color[2];

    float chartHeight;

    [SerializeField]
    private GameObject logo;

    // Start is called before the first frame update
    void Start()
    {
        chartHeight = Screen.height + GetComponent<RectTransform>().sizeDelta.y;

        if (LevelManager.final_Level_Check_Normal)
        {
            logo.SetActive(false);
            DisplayGraph_Forcus(inputValues);
        }
    }

    void DisplayGraph_Forcus(int[] vals)
    {
        //int MaxValue = vals.Max();
        //최대 값
        int MaxValue = 1000;
        //집중력
        vals[0] = 440;
        vals[1] = ScoreManager.all_Forcus_Score_Normal * 2;
        //기억력
        vals[6] = 750;
        vals[7] = ScoreManager.all_Memory_Score_Normal * 10;
        //순발력
        vals[12] = 660;
        vals[13] = ScoreManager.all_Time_Score_Normal;
        for (int i = 0; i < vals.Length; i++)
        {
            Bar newBar = Instantiate(barPrefab) as Bar;
            newBar.transform.SetParent(transform);
            //바 크기 조절
            RectTransform rt = newBar.bar.GetComponent<RectTransform>();
            float normalizedValue = ((float)vals[i] / (float)MaxValue) * 0.35f;
            rt.sizeDelta = new Vector2(rt.sizeDelta.x, chartHeight * normalizedValue);
            newBar.bar.color = colors[i % colors.Length];



        }
        //바 텍스트
        //newBar.barValue.text = vals[0].ToString();
        //newBar.barValue.text = vals[1].ToString();
        //newBar.barValue.text = vals[6].ToString();
        //newBar.barValue.text = vals[7].ToString();
        //newBar.barValue.text = vals[12].ToString();
        //newBar.barValue.text = vals[13].ToString();
    }

}
