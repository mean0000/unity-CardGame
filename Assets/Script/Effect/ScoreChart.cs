using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreChart : MonoBehaviour
{
    [SerializeField]
    private GameObject easy_Focus_total;
    [SerializeField]
    private GameObject easy_Focus_user;
    [SerializeField]
    private GameObject easy_Memory_total;
    [SerializeField]
    private GameObject easy_Memory_user;
    [SerializeField]
    private GameObject easy_Speed_total;
    [SerializeField]
    private GameObject easy_Speed_user;

    private RectTransform rect_Focus_total;
    private RectTransform rect_Focus_user;
    private RectTransform rect_Memory_total;
    private RectTransform rect_Memory_user;
    private RectTransform rect_Speed_total;
    private RectTransform rect_Speed_user;

    // Start is called before the first frame update
    void Start()
    {
        //집중력
        rect_Focus_total = easy_Focus_total.GetComponent<RectTransform>();
        rect_Focus_total.anchoredPosition = new Vector2(-740, 360);
        rect_Focus_total.sizeDelta = new Vector2(740, 300);

        rect_Focus_user = easy_Focus_user.GetComponent<RectTransform>();
        rect_Focus_user.anchoredPosition = new Vector2(-700, 277);
        rect_Focus_user.sizeDelta = new Vector2(700, 210);

        //기억력
        rect_Memory_total = easy_Memory_total.GetComponent<RectTransform>();
        rect_Memory_total.anchoredPosition = new Vector2(-596, 277);
        rect_Memory_total.sizeDelta = new Vector2(596, 210);

        rect_Memory_user = easy_Memory_user.GetComponent<RectTransform>();
        rect_Memory_user.anchoredPosition = new Vector2(-556, 277);
        rect_Memory_user.sizeDelta = new Vector2(556, 210);

        //순발력
        rect_Speed_total = easy_Speed_total.GetComponent<RectTransform>();
        rect_Speed_total.anchoredPosition = new Vector2(-452, 277);
        rect_Speed_total.sizeDelta = new Vector2(452, 210);

        rect_Speed_user = easy_Speed_user.GetComponent<RectTransform>();
        rect_Speed_user.anchoredPosition = new Vector2(-412, 277);
        rect_Speed_user.sizeDelta = new Vector2(412, 210);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
