using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScreenCapture : MonoBehaviour
{
    public Texture2D capturedImage; //캡처된 이미지 저장
    public Material saveCapture;
    public static string userName;

    [SerializeField]
    private TextMeshProUGUI guide_Text;
    [SerializeField]
    private GameObject guide_Img;
    [SerializeField]
    private GameObject loading_Img;

    private bool CountDonw_Check = false;
    private float currentTime = 0;
    private int count = 0;

    private void Start()
    {
        CountDonw_Check = true;
        XmlManager.instance.CreateXml();
    }

    public IEnumerator capture()
    {
        //전체 화면 캡처
        Rect lRect = new Rect(0f, 0f, Screen.width, Screen.height);
        if (capturedImage)
            Destroy(capturedImage);

        yield return new WaitForEndOfFrame();
        capturedImage = zzTransparencyCapture.capture(lRect);

        //material의 texture에 captureImage 저장
        try
        {
            saveCapture.SetTexture("_MainTex", capturedImage);
        }
        catch(UnassignedReferenceException e) 
        {
            Debug.Log(e);
        }
    }

    public void Update()
    {
        currentTime += Time.unscaledDeltaTime;
        if (currentTime >= 1)
        {
            guide_Text.text = "2초간 정면을 바라봐 주세요.";
            if (currentTime >= 2)
            {
                guide_Text.text = "1초간 정면을 바라봐 주세요.";
                if (currentTime >=3 && CountDonw_Check)
                {
                    userName = "Luke";
                    
                    //XmlManager.instance.SaveOverlapXml();

                    guide_Text.text = "";
                    guide_Img.SetActive(false);
                    currentTime = 0;
                    CountDonw_Check = false;
                    StartCoroutine(capture());
                    loading_Img.SetActive(true);
                    PageManager.Instance.ChangeView_Load(2);
                }
            }
        }

        //c 눌렀을 때 캡처
        if (Input.GetKeyDown(KeyCode.C))
            StartCoroutine(capture());
        //s 눌렀을 때 캡처 지움
        if (Input.GetKeyDown(KeyCode.S))
            Destroy(capturedImage);
    }

    //gui화면에 보여줌.
    void OnGUI()
    {
        if (capturedImage)
        {
            GUI.DrawTexture(
                new Rect(Screen.width * 0.1f, Screen.height * 0.1f, Screen.width * 0.8f, Screen.height * 0.8f),
                capturedImage,
                ScaleMode.ScaleToFit,
                true);
            GUI.color = Color.green;
        }

        GUI.color = Color.black;
    }

    public void Capture()
    {
        StartCoroutine(capture());
    }
}
