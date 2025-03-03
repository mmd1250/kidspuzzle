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
        if (currentPage > 1)
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

    public void OnEndDrag(PointerEventData eventData)
    {
        if (Mathf.Abs(eventData.position.x - eventData.pressPosition.x) > DragThreshould)
        {
            if (eventData.position.x > eventData.pressPosition.x)
            {
                Previous();
            }
            else
            {
                Next();
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
            previousBtn.interactable = false;
            PageBarNum1.SetActive(true);
            PageBarNum2.SetActive(false);
            PageBarNum3.SetActive(false);
        }
        else if (currentPage == maxPage)
        {
            PageBarNum1.SetActive(false);
            PageBarNum2.SetActive(false);
            PageBarNum3.SetActive(true);
            nextBtn.interactable = false;
        }
        else
        {
            PageBarNum1.SetActive(false);
            PageBarNum2.SetActive(true);
            PageBarNum3.SetActive(false);
        }
    }
}
