using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class Hint_Activate : MonoBehaviour
{
    public GameObject Pointer;

    public GameObject[] Starts;  // [0] = Part1, [1] = Part2, [2] = Part3
    public GameObject[] Targets; // [0] = Shadow1, [1] = Shadow2, [2] = Shadow3


    private Vector2 PointerStartPosition;

    private float timer = 0f;
    private bool isHintPlaying = false;

    void Start()
    {
        
        //StartCoroutine(WaitTime());
    }

    
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 15f && !isHintPlaying)
        {
            StartCoroutine(WaitTime());
            timer = 0f; // ???? ?????
        }
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
        for (int i = 0; i < 3; i++)
        {
            
            // ????? ?????? ???? ??????
            Pointer.transform.position = Starts[rand].transform.position;

            LeanTween.move(Pointer, Targets[rand].transform.position, 2f).setEase(LeanTweenType.easeInOutQuad);

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
