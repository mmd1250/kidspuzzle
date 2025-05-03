using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class winLevel5part : MonoBehaviour
{
    public GameObject shadowPart1;
    public GameObject shadowPart2;
    public GameObject shadowPart3;
    public GameObject shadowPart4;
    public GameObject shadowPart5;



    public GameObject Part1;
    public GameObject Part2;
    public GameObject Part3;
    public GameObject Part4;
    public GameObject Part5;



    public GameObject shadowPartFull;
    public GameObject FullPart;
    public static int winHelper;
    private static int lockSoundPlayHelper;

    public static int pauseHelper;
    public static int starHelper;
    public Image starAnim;
    public Text starNumber;

    //firework
    public GameObject fire1;
    public GameObject fire2;
    public GameObject fire3;
    // Start is called before the first frame update
    void Start()
    {

        winHelper = 0;
        lockSoundPlayHelper = 0;
        pauseHelper = 0;

        fire1.SetActive(false);
        fire2.SetActive(false);
        fire3.SetActive(false);
        starHelper = 1;
    }

    public static void lockSoundPlay()
    {
        lockSoundPlayHelper = 1;

    }

    // Update is called once per frame
    void Update()
    {

        if (lockSoundPlayHelper == 1)
        {
            gameObject.GetComponent<AudioSource>().Play();
            lockSoundPlayHelper = 0;

        }


        if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && part5.locked5 && pauseHelper == 0)
        {
            GameController5tike.pauseHelper = 1;

            shadowPart1.SetActive(false);
            shadowPart2.SetActive(false);
            shadowPart3.SetActive(false);
            shadowPart4.SetActive(false);
            shadowPart5.SetActive(false);


            Part1.SetActive(false);
            Part2.SetActive(false);
            Part3.SetActive(false);
            Part4.SetActive(false);
            Part5.SetActive(false);


            shadowPartFull.SetActive(false);


            if (starHelper == 1)
            {
                fire1.SetActive(true);

                starHelper = 0;
                //starAnim.gameObject.GetComponent<Animator>().enabled = true;
                //starAnim.gameObject.SetActive(true);
                StartCoroutine(star());
                StartCoroutine(starSet());
                StartCoroutine(fire2C());
                StartCoroutine(fire3C());
                PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star", 0) + 5);
            }

            FullPart.SetActive(true);
            FullPart.GetComponent<SpriteRenderer>().sortingOrder = 10;
            StartCoroutine(winGame());
            StartCoroutine(stopFire());
        }
    }
    IEnumerator stopFire()
    {

        yield return new WaitForSeconds(3.6f);
        fire1.SetActive(false);
        fire2.SetActive(false);
        fire3.SetActive(false);

    }
    IEnumerator fire2C()
    {

        yield return new WaitForSeconds(0.4f);
        fire2.SetActive(true);
    }
    IEnumerator fire3C()
    {

        yield return new WaitForSeconds(0.9f);
        fire3.SetActive(true);

    }
    IEnumerator winGame()
    {

        yield return new WaitForSeconds(4f);
        winHelper = 1;
    }
    IEnumerator star()
    {

        yield return new WaitForSeconds(3.3f);
        starAnim.gameObject.GetComponent<Animator>().enabled = false;

        //starAnim.gameObject.SetActive(false);

    }
    IEnumerator starSet()
    {

        yield return new WaitForSeconds(0.85f);
        starNumber.text = PlayerPrefs.GetInt("Star", 0).ToString();

    }
}
