using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.UI;

public class CameraManager : MonoBehaviour
{
    WebCamTexture camTexture;
    public RawImage cameraViewImage; //카메라 화면


    void Start()
    {
        CameraOn();
    }

    public void CameraOn()
    {
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
        }

        //카메라가 없다면
        if(WebCamTexture.devices.Length == 0)
        {
            Debug.Log("no camera!!!!");
            return;
        }

        WebCamDevice[] devices = WebCamTexture.devices;
        int selectCameraIndex = -1;

        for(int i = 0; i < devices.Length; i++)
        {
            if (devices[i].isFrontFacing == true)
            {
                selectCameraIndex = i;
                break;
            }
        }


        if(selectCameraIndex >= 0)
        {
            camTexture = new WebCamTexture(devices[selectCameraIndex].name);
            camTexture.requestedFPS = 60;
            cameraViewImage.texture = camTexture;
            camTexture.Play();
        }
    }

    public void CameraOff() 
    { 
        if(camTexture != null)
        {
            camTexture.Stop();
            WebCamTexture.Destroy(camTexture);
            camTexture = null;
        }
    }

}

