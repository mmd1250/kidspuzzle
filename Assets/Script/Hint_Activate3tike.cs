using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Hint_Activate3tike : MonoBehaviour
{
    public GameObject Pointer;

    public float Counter;
    public GameObject[] Starts;  // [0] = Part1, [1] = Part2, [2] = Part3
    public GameObject[] Targets; // [0] = Shadow1, [1] = Shadow2, [2] = Shadow3

    private GameObject PausePanel;
    public  GameObject PausePanel1;

    private Vector2 PointerStartPosition;

    private float timer = 0f;
    private bool isHintPlaying = false;

    public int flag;
    void Start()
    {
        if (PausePanel == null)
        {
            PausePanel = GameObject.FindWithTag("Panel");
            Debug.Log("nulle baba");

        }
        PointerStartPosition = Pointer.transform.position;
        if (PausePanel != null && PausePanel.activeInHierarchy == false)
        {
            // flag active boodane panel
            flag = 0;
        }
        else if (PausePanel != null && PausePanel.activeInHierarchy == true)
        {
            // flag active boodane panel
            flag = 1;
        }
        //StartCoroutine(WaitTime());
    }
    void Awake()
    {
        if (PausePanel == null)
        {
            PausePanel = GameObject.FindWithTag("Panel"); // ?? ?? Tag/Name ??????? ??
            Debug.Log("panel nulle");
        }
    }


    void Update()
    {
        //PausePanel = GameObject.FindWithTag("Panel");
        if (PausePanel1 != null && PausePanel1.activeInHierarchy == false)
        {
            // flag active boodane panel
            flag = 0;
        }
        else if (PausePanel1 != null && PausePanel1.activeInHierarchy == true)
        {
            // flag active boodane panel
            flag = 1;
        }
        if (flag == 0)
        {
            timer += Time.deltaTime;
            if (timer >= 15f && !isHintPlaying)
            {

                StartCoroutine(WaitTime());
                timer = 0f; // ???? ?????
            }
        }




        Counter = timer;
    }


    IEnumerator WaitTime()
    {



        isHintPlaying = true;
        Pointer.SetActive(true);

        // ????? ?? ??????????? ?? ???? ????? ?? ?????? ????
        List<int> availableHints = new List<int>();

        for (int i = 0; i < Targets.Length; i++)
        {
            // ??? ?????? ?? ???? ???? (???? ???? ?? ????)
            if (Targets[i].GetComponent<SpriteRenderer>().enabled == false)
            {
                availableHints.Add(i);
            }
        }
        // ??? ??? ?? ???? ???? ???????? ???? ????
        if (availableHints.Count == 0)
        {
            Pointer.SetActive(false);
            isHintPlaying = false;
            yield break;
        }
        int rand = availableHints[Random.Range(0, availableHints.Count)];
        Vector3 offset = new Vector3(0.4f, -0.2f, 0); // ???? ? ?????
        for (int i = 0; i < 3; i++)
        {

            // ????? ?????? ???? ??????
            Pointer.transform.position = Starts[rand].transform.position + offset;

            LeanTween.move(Pointer, Targets[rand].transform.position + offset, 2f).setEase(LeanTweenType.easeInOutQuad);

            // ??? ?? ?? ???? ???? ??
            yield return new WaitForSeconds(2f);

            // ??? ????? ?? ?????? ?????
            Pointer.transform.position = PointerStartPosition;

            // ??? ????? ??? ?? ???? ???? (???????)
            //yield return new WaitForSeconds(0.2f);
        }
        isHintPlaying = false;
        Pointer.SetActive(false);

    }
}
