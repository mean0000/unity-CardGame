using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationEffect : MonoBehaviour
{
    private int _rotSpeed = 5;

    private float spin_Value;

    // Update is called once per frame
    void Update()
    {
        spin_Value = _rotSpeed * Time.deltaTime;
        //Debug.Log(gameObject.transform.rotation.eulerAngles.z);
        //transform.Rotate(0, 0, spin_Value);
        if(gameObject.transform.rotation.eulerAngles.z < 8 )
        {
            spin_Value = _rotSpeed * Time.deltaTime;
            transform.Rotate(0, 0, spin_Value);
        }
        else if(gameObject.transform.rotation.eulerAngles.z > 8 && gameObject.transform.rotation.eulerAngles.z < 20)
        {
            _rotSpeed = -5;
            spin_Value = (_rotSpeed * Time.deltaTime);
            transform.Rotate(0, 0, spin_Value);
        }
        else if (gameObject.transform.rotation.eulerAngles.z > 340)
        {
            _rotSpeed = 5;
            spin_Value = (_rotSpeed * Time.deltaTime);
            transform.Rotate(0, 0, spin_Value);
        }

    }

    void resetAnim()
    {
        transform.rotation = Quaternion.identity;
    }
}
