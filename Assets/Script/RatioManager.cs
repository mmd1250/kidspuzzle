using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatioManager : MonoBehaviour
{
    //public Camera maincamera;
    float aspectRatio = (float)Screen.width / Screen.height;
    float targetAspect = 16f / 9f;
    float baseSize = 5f; // ???? ????????? ???????????
    public CanvasScaler canvasScaler;  // یا می‌تونی با GetComponent بگیری

    // Start is called before the first frame update
    //void Start()

    //AdjustCameraSize();


    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.1f);

        int w = Screen.width;
        int h = Screen.height;
        float aspectRatio = (float)w / h;
        Debug.Log("Actual resolution: " + w + "x" + h);
        Debug.Log("Aspect Ratio: " + aspectRatio);



        // اگه دستی از Inspector ندی، اینجا بگیرش
        if (canvasScaler == null)
            canvasScaler = GetComponent<CanvasScaler>();

        // تغییر حالت به Scale With Screen Size
        //canvasScaler.uiScaleMode = CanvasScaler.ScaleMode.ScaleWithScreenSize;

        // تنظیم رزولوشن مرجع
        canvasScaler.referenceResolution = new Vector2(h, w);

        // انتخاب اینکه با عرض یا ارتفاع مقایسه کنه (0 = عرض، 1 = ارتفاع)
        canvasScaler.screenMatchMode = CanvasScaler.ScreenMatchMode.MatchWidthOrHeight;
        canvasScaler.matchWidthOrHeight = 0f; // 0 برای فقط عرض، 1 برای فقط ارتفاع، 0.5 برای ترکیب
    }

}
