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
        cardFindCount.text = LevelManager.Instance.findCount.ToString();
        cardTargetCount.text = LevelManager.Instance.targetCount.ToString();
        cardBackTargetCount.text = LevelManager.Instance.targetCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       cardFindCount.text = LevelManager.Instance.findCount.ToString();
       cardBackTargetCount.text = (LevelManager.Instance.targetCount - LevelManager.Instance.findCount).ToString("D2");
    }
}

