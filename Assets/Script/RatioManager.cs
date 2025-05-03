using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatioManager : MonoBehaviour
{
    //public Camera maincamera;
    float aspectRatio = (float)Screen.width / Screen.height;
    float targetAspect = 16f / 9f;
    float baseSize = 5f; // ???? ????????? ???????????

    // Start is called before the first frame update
    void Start()
    {
        AdjustCameraSize();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AdjustCameraSize()
    {
        float targetAspect = 9f / 16f; // نسبت تصویر مرجع (مثلاً 9:16 برای گوشی پرترایت)
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Camera cam = Camera.main;

        if (scaleHeight < 1.0f)
        {
            // صفحه باریک‌تر از حالت مرجع است - پس ارتفاع زیاد می‌کنیم
            cam.orthographicSize = cam.orthographicSize / scaleHeight;
        }
        float currentAspect = (float)Screen.width / (float)Screen.height;
        float scaleFactor = targetAspect / currentAspect;

        if (scaleFactor > 1f)
        {
            // یعنی صفحه بلندتر از حالت مرجع شده (مثل 4:3)
            cam.orthographicSize *= scaleFactor;
        }

    }

}
