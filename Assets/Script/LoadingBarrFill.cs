using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class LoadingBarrFill : MonoBehaviour
{
    public Slider slider; // ?????? ??? ?? ???? ??????
    //public float fillDuration = 2f; // ??? ???? ?? ???
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FillSliderOverTime(3f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator FillSliderOverTime(float duration)
    {
        float timeElapsed = 0f;
        while (timeElapsed < duration)
        {
            timeElapsed += Time.deltaTime;
            slider.value = Mathf.Lerp(0f, 100f, timeElapsed / duration);
            yield return null;
        }
        slider.value = 100f; // ??????? ?? ?? ??? ???? ???????
    }

}
