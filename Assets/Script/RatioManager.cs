using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RatioManager : MonoBehaviour
{
    public Camera maincamera;
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
        float aspectRatio = (float)Screen.width / Screen.height;
        float targetAspect = 16f / 9f;
        float baseSize = 5f; // ???? ????????? ???????????

        if (aspectRatio < targetAspect)
        {
            maincamera.orthographicSize = baseSize * (targetAspect / aspectRatio);
        }
        else
        {
            maincamera.orthographicSize = baseSize;
        }
    }

}
