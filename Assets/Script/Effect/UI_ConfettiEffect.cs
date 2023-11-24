using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ConfettiEffect : MonoBehaviour
{
    [SerializeField] float moveX, moveY; // 날아갈 목표 지점
    [SerializeField] float moveDurationX, moveDurationY, rotateDuration; // 모션 소요 시간
    [SerializeField] float randomRangeY; // 조각들의 y축 생성 범위
    [SerializeField] Ease easeX, easeY; // 날아가는 모션의 이징값

    List<ConfettiScript> confetties;

    private void Awake()
    {
        confetties = new List<ConfettiScript>();
        foreach (Transform child in transform)
        {
            confetties.Add(child.GetComponent<ConfettiScript>());
        }
    }

    //private void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.Space)) Show(); // Test
    //}

    public void Show()
    {
        foreach (ConfettiScript confetti in confetties)
        {
            confetti.Play(moveX, moveY, moveDurationX, moveDurationY, randomRangeY, rotateDuration, easeX, easeY);
        }
    }
}
