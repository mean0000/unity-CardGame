using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ConfettiScript : MonoBehaviour
{
    Vector3 initPos;

    public void Play(float moveX, float moveY, float moveDurationX, float moveDurationY, float randomRangeY, float rotateDuration, Ease easeX, Ease easeY)
    {
        if (initPos == null)
        {
            // 첫 실행시 초기화 하지 않고 위치 초기값만 저장
            initPos = transform.localPosition;
        }
        else
        {
            // 두번째 이상 실행 시 초기화
            transform.DOKill(); // 이전 트윈 제거(충돌방지)
            transform.localScale = Vector3.one * Random.Range(2f, 4f); // 랜덤 스케일
            transform.localPosition = initPos; // 위치 초기화
        }
        // 랜덤 y축 포지션 설정
        transform.localPosition += Vector3.up * Random.Range(-randomRangeY, randomRangeY);

        float speedUnit = Random.Range(.5f, 1f); // 랜덤 이동속도 설정
        float delay = Random.Range(0f, .6f); // 랜덤 시작 딜레이 설정

        // x축 단방향 이동
        transform.DOMoveX(moveX * (speedUnit + Random.Range(-.1f, .1f)), moveDurationX)
                 .SetRelative()
                 .SetEase(easeX)
                 .SetDelay(delay);
        // y축 포물선 이동
        transform.DOMoveY(moveY * (speedUnit + Random.Range(-.1f, .1f)), moveDurationY)
                 .SetRelative()
                 .SetEase(easeY, 2)
                 .SetDelay(delay);
        // z축 무한 회전 (회전 방향은 이동 방향에 따라 결정됨)
        transform.DORotate(new Vector3(0, 0, moveX > 0 ? -360 : 360), rotateDuration * (speedUnit + Random.Range(-.1f, .1f)), RotateMode.FastBeyond360)
                 .SetLoops(-1, LoopType.Incremental)
                 .SetEase(Ease.Linear)
                 .SetId("Rotate" + GetInstanceID());
        // 스케일 축소 (y축 이동이 끝나기 직전)
        transform.DOScale(0, .5f)
                 .SetDelay((moveDurationY + delay) - .5f)
                 .OnComplete(Stop);
    }

    private void Stop()
    {
        // 무한으로 실행되고 있는 회전 트윈 제거
        DOTween.Kill("Rotate" + GetInstanceID());
    }
}
