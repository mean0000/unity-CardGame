using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CardCount : MonoBehaviour
{
    public Text cardFindCount; //찾은 개수
    public Text cardTargetCount; //목표 개수
    public Text cardBackTargetCount; //목표 개수


    // Start is called before the first frame update
    void Start()
    {        
        cardFindCount.text = LevelManager.findCount.ToString();
        cardTargetCount.text = LevelManager.targetCount.ToString();
        cardBackTargetCount.text = LevelManager.targetCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       cardFindCount.text = LevelManager.findCount.ToString();
       cardBackTargetCount.text = (LevelManager.targetCount - LevelManager.findCount).ToString("D2");
    }
}

