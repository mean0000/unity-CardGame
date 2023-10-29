using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_CardCount : MonoBehaviour
{
    private LevelManager levelManager;

    public Text cardFindCount; //찾은 개수
    public Text cardTargetCount; //목표 개수

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

        cardFindCount.text = levelManager.findCount.ToString();
        cardTargetCount.text = levelManager.targetCount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       cardFindCount.text = levelManager.findCount.ToString();
    }
}

