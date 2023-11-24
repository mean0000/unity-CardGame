using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BiggerEffect : MonoBehaviour
{
    float time;

    // Update is called once per frame
    void Update()
    {

        transform.localScale = Vector3.one * ((1f + time) * 0.005f);
        time += Time.deltaTime;
        //if (time > 1f)
        //{
        //    gameObject.SetActive(false);
        //}
    }

    public void resetAnim()
    {
        time = 0;
        transform.localScale = Vector3.one;
    }
}
