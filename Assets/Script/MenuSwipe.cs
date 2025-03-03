using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SwipePageController : MonoBehaviour
{
    public RectTransform[] pages; // ????? ?? ?????
    private int currentIndex = 0; // ???? ????

    private Vector2 touchStartPos, touchCurrentPos;
    public float snapThreshold = 0.3f; // ????? ???? ???? ???? ????? ????
    public float smoothSpeed = 10f; // ???? ?????? ?? ????? ????
    private bool isDragging = false;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                touchStartPos = touch.position;
                isDragging = true;
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                touchCurrentPos = touch.position;
                DragPages();
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                isDragging = false;
                SnapToPage();
            }
        }

        if (!isDragging)
        {
            // ??? ????? ???? ?? ??????? ???? ?? ?? ?????? ???? ???? ????????????
            for (int i = 0; i < pages.Length; i++)
            {
                Vector2 targetPos = new Vector2((i - currentIndex) * Screen.width, 0);
                pages[i].anchoredPosition = Vector2.Lerp(pages[i].anchoredPosition, targetPos, Time.deltaTime * smoothSpeed);
            }
        }
    }

    void DragPages()
    {
        float dragAmount = touchCurrentPos.x - touchStartPos.x;

        // ???? ???? ????? ?? ???? ????? Drag
        for (int i = 0; i < pages.Length; i++)
        {
            pages[i].anchoredPosition = new Vector2((i - currentIndex) * Screen.width + dragAmount, 0);
        }
    }

    void SnapToPage()
    {
        float dragAmount = touchCurrentPos.x - touchStartPos.x;
        float percentageDragged = Mathf.Abs(dragAmount) / Screen.width;

        if (percentageDragged > snapThreshold)
        {
            if (dragAmount < 0 && currentIndex < pages.Length - 1)
                currentIndex++;
            else if (dragAmount > 0 && currentIndex > 0)
                currentIndex--;
        }
    }
}
