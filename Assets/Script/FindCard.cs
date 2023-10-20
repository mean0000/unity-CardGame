using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindCard : MonoBehaviour
{

    [SerializeField]
    private SpriteRenderer findCardRenderer;
  
    public int findCardID;

    public void SetFindCardID(int id)
    {
        findCardID = id;
        //Debug.Log("FindCardID: " + findCardID);
    }
    public void SetFrontSprite(Sprite sprite)
    {
        //frontSprite = sprite;
        findCardRenderer.sprite = sprite;
    }

}
