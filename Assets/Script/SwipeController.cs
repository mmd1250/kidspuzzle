using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwipeController : MonoBehaviour,IEndDragHandler
{

    public GameObject PageBarNum1;
    public GameObject PageBarNum2;
    public GameObject PageBarNum3;
    [SerializeField] int maxPage;
    int currentPage;
    Vector3 TargetPos;
    [SerializeField] Vector3 PageStep;
    [SerializeField] RectTransform LevelPagesRect;

    [SerializeField] ScrollRect scrollRect;


    [SerializeField] float tweenTime;
    [SerializeField] LeanTweenType tweenType;

    float DragThreshould;


    [SerializeField] Button previousBtn, nextBtn;

    private void Awake()
    {
        currentPage = 1;
        TargetPos = LevelPagesRect.localPosition;
        DragThreshould = Screen.width / 15;
        UpdateArrowButton();
    }
    public void Next()
    {
        if (currentPage < maxPage)
        {
            currentPage++;
            TargetPos += PageStep;
            MovePage();
        }
    }
    public void Previous()
    {
        if (currentPage > 1 && currentPage !=1)
        {
            currentPage--;
            TargetPos -= PageStep;
            MovePage();
        }
    }
    public void MovePage()
    {
        LevelPagesRect.LeanMoveLocal(TargetPos, tweenTime).setEase(tweenType);
        UpdateArrowButton();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnDrag(PointerEventData eventData)
    {
        float delta = eventData.position.x - eventData.pressPosition.x;

        if (currentPage == 1 && delta > 0)
        {
            // توی صفحه اول هستیم و کاربر می‌خواد به چپ بکشه => جلوگیری می‌کنیم
            eventData.Use();
        }
        else if (currentPage == maxPage && delta < 0)
        {
            // توی صفحه آخر هستیم و کاربر می‌خواد به راست بکشه => جلوگیری می‌کنیم
            eventData.Use();
        }
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        float delta = eventData.position.x - eventData.pressPosition.x;
        if (Mathf.Abs(delta) > DragThreshould)
        {
            if (delta > 0)
            {
                if (currentPage > 1) 
                {
                    Previous();
                }
                
            }
            else
            {
                // کاربر کشید به سمت چپ (میخواد بره صفحه بعد)
                if (currentPage < maxPage)
                {
                    Next();
                }
            }
        }
        else
        {
            MovePage();
        }
    }
    void UpdateArrowButton()
    {
        nextBtn.interactable = true;
        previousBtn.interactable = true;
        if (currentPage == 1) 
        {
            Menu.level = 1;
            previousBtn.interactable = false;
            scrollRect.horizontal = false; // صفحه اول، جلو کشیدن رو می‌گیریم
            PageBarNum1.SetActive(true);
            PageBarNum2.SetActive(false);
            PageBarNum3.SetActive(false);
        }
        else if (currentPage == maxPage)
        {
            Menu.level = 3;
            scrollRect.horizontal = false; // صفحه آخر، عقب کشیدن رو می‌گیریم
            PageBarNum1.SetActive(false);
            PageBarNum2.SetActive(false);
            PageBarNum3.SetActive(true);
            nextBtn.interactable = false;
        }
        else
        {
            Menu.level = 2;
            PageBarNum1.SetActive(false);
            PageBarNum2.SetActive(true);
            PageBarNum3.SetActive(false);
        }
    }
}
