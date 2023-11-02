using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager : MonoBehaviour
{
    public static EffectManager Instance;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    //effect
    public CardSelectEffect cardSelectEffect;
    public UI_ConfettiEffect ui_confettiEffect_R;
    public UI_ConfettiEffect ui_confettiEffect_L;
    public PopupEffect popupEffect;
    public FlowEffect flowEffect;
}
