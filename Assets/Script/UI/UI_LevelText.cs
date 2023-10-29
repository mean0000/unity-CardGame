using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_LevelText : MonoBehaviour
{
    private LevelManager levelManager;

    public Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

        levelText.text = levelManager.leveltext;
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = levelManager.leveltext;
    }
}
