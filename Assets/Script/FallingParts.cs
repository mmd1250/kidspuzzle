using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FallingParts : MonoBehaviour
{
    public GameObject part1Shadow;
    public GameObject part2Shadow;
    public GameObject part3Shadow;


    public GameObject part1;
    public GameObject part2;
    public GameObject part3;


    public GameObject MainPart1;
    public GameObject MainPart2;
    public GameObject MainPart3;

    // Start is called before the first frame update
    void Start()
    {
        part1.transform.position = part1Shadow.transform.position;
        part2.transform.position = part2Shadow.transform.position;
        part3.transform.position = part3Shadow.transform.position;
        StartCoroutine(FallTimer());

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator FallTimer()
    {
        yield return new WaitForSeconds(2);
        LeanTween.move(part1, MainPart1.transform.position, 1.2f).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.move(part2, MainPart2.transform.position, 1.2f).setEase(LeanTweenType.easeInOutQuad);
        LeanTween.move(part3, MainPart3.transform.position, 1.2f).setEase(LeanTweenType.easeInOutQuad)
            .setOnComplete(() => // ????? ????? ???? ???? ?? ??? ????? ???? ??
            {
            part1.SetActive(false);
            part2.SetActive(false);
            part3.SetActive(false);
            MainPart1.GetComponent<SpriteRenderer>().enabled = true;
            MainPart2.GetComponent<SpriteRenderer>().enabled = true;
            MainPart3.GetComponent<SpriteRenderer>().enabled = true;
        });
        
        //MainPart1.SetActive(true);
        //MainPart2.SetActive(true);
        //MainPart3.SetActive(true);
    }
}
