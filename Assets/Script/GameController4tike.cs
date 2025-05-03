using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TapsellSDK;


public class GameController4tike : MonoBehaviour
{
    private int LevelNumber;
    private int selectedLevelNumber;
    string tapsellKey = "rahqjisrhsmpfapomoqsrfjefaoqcparseaqqscfndfgskootkcdjmsjbicibbsaaapacs";

    int initialAdHelper;
    int tapsellHelper;  // for avalabing ad


    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;
    public GameObject Level7;
    public GameObject Level8;
    public GameObject Level9;
    public GameObject Level10;
    public GameObject Level11;
    public GameObject Level12;
    public GameObject Level13;
    public GameObject Level14;
    public GameObject Level15;

    public Sprite soundOn;
    public Sprite soundOff;
    public Button sound;

    //public Text starNumber;

    public Animator Panel_Animator;
    public static AudioClip lockPart;
    public static int adHelper;
    string zoneId = "606ae81114e5b90001c817c0";
    public static TapsellAd ad;
    TapsellShowOptions showOptions = new TapsellShowOptions();
    public static int pauseHelper; // for disabaling pause during win animation


    public Button pause;

    public GameObject pausePanel;


    //public AudioSource PlupSoundAudioSource;

    public AudioSource PauseAudioSource;
    public AudioSource ResumeAudioSource;



    public static int TouchHelper;
    // public ParticleSystem fireWorks;
   
    
    // Start is called before the first frame update
    void Start()
    {
        initialAdHelper = 1;

        pauseHelper = 0;
        adHelper = 0;
        // starAnim.gameObject.SetActive(true);
        //request();
        if (PlayerPrefs.GetInt("sound", 1) == 1) // 1 mean on, 0 mean off
        {
            //AudioListener.volume = 1;
            //sound.GetComponent<Image>().sprite = soundOn;

        }
        if (PlayerPrefs.GetInt("sound", 1) == 0) // 1 mean on, 0 mean off
        {
            //AudioListener.volume = 0;
            //sound.GetComponent<Image>().sprite = soundOff;


        }
        //starNumber.text = PlayerPrefs.GetInt("Star", 0).ToString();

        part1.locked1 = true;
        part2.locked2 = true;
        part3.locked3 = true;
        part4.locked4 = true;

        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        part4.locked4 = false;

        TouchHelper = 0;
        // PlayerPrefs.DeleteAll(); // for test

        LevelNumber = PlayerPrefs.GetInt("LevelNumber", 16);
        selectedLevelNumber = PlayerPrefs.GetInt("levelSelected", 16);


        pausePanel.gameObject.SetActive(false);
        switch (selectedLevelNumber)
        {
            case 16:
                Level1.SetActive(true);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);




                break;

            case 17:
                Level1.SetActive(false);
                Level2.SetActive(true);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;

            case 18:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(true);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;

            case 19:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(true);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;

            case 20:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(true);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 21:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(true);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 22:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(true);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 23:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(true);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 24:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(true);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 25:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(true);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 26:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(true);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 27:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(true);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 28:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(true);
                Level14.SetActive(false);
                Level15.SetActive(false);


                break;
            case 29:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(true);
                Level15.SetActive(false);


                break;
            case 30:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                Level6.SetActive(false);
                Level7.SetActive(false);
                Level8.SetActive(false);
                Level9.SetActive(false);
                Level10.SetActive(false);
                Level11.SetActive(false);
                Level12.SetActive(false);
                Level13.SetActive(false);
                Level14.SetActive(false);
                Level15.SetActive(true);


                break;
        }
        //fireWorks.enableEmission = false;

    }
    public void soundOnOff()
    {
        if (PlayerPrefs.GetInt("sound", 1) == 1) // 1 mean on, 0 mean off
        {
            PlayerPrefs.SetInt("sound", 0);
            AudioListener.volume = 0f;
            sound.GetComponent<Image>().sprite = soundOff;
            return;

        }
        if (PlayerPrefs.GetInt("sound", 1) == 0) // 1 mean on, 0 mean off
        {
            PlayerPrefs.SetInt("sound", 1);
            AudioListener.volume = 1f;
            sound.GetComponent<Image>().sprite = soundOn;

            return;

        }
    }
    IEnumerator reqad()
    {

        yield return new WaitForSeconds(15f);
        //request();

    }
    IEnumerator initAds()
    {

        yield return new WaitForSeconds(60f);
        Tapsell.Initialize(tapsellKey);
        initialAdHelper = 1;


    }
    // Update is called once per frame
    void Update()
    {
        if (initialAdHelper == 1)
        {
            StartCoroutine(initAds());
            initialAdHelper = 0;
        }

        if (adHelper >= 5 && PlayerPrefs.GetInt("ads", 1) == 1 && tapsellHelper == 1)
        {
            //showads();
            adHelper = 0;
            StartCoroutine(reqad());

        }
        if (pauseHelper == 1)
        {
            pause.interactable = false;
        }
        //Debug.Log("level" + selectedLevelNumber);

        switch (selectedLevelNumber)
        {
            
            case 16:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper ==1)
                {
                    if(selectedLevelNumber == LevelNumber)
                    {

                        PlayerPrefs.SetInt("LevelNumber", 17);

                    }
                    Debug.Log("level" + selectedLevelNumber);
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 17);
                    Debug.Log("2");
                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(true);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;
                }
                break;
            case 17:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 18);

                    }
                    PlayerPrefs.SetInt("levelSelected", 18);
                    adHelper++;

                    Debug.Log("3");
                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(true);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 18:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 19);

                    }
                    PlayerPrefs.SetInt("levelSelected", 19);
                    Debug.Log("4");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(true);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 19:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 20);

                    }
                    PlayerPrefs.SetInt("levelSelected", 20);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(true);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 20:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 21);

                    }
                    PlayerPrefs.SetInt("levelSelected", 21);
                    Debug.Log("6");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(true);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;

            case 21:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 22);

                    }
                    PlayerPrefs.SetInt("levelSelected", 22);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(true);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 22:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 23);

                    }
                    PlayerPrefs.SetInt("levelSelected", 23);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(true);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 23:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 24);

                    }
                    PlayerPrefs.SetInt("levelSelected", 24);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(true);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 24:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 25);

                    }
                    PlayerPrefs.SetInt("levelSelected", 25);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(true);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 25:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 26);

                    }
                    PlayerPrefs.SetInt("levelSelected", 26);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(true);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 26:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 27);

                    }
                    PlayerPrefs.SetInt("levelSelected", 27);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(true);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 27:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 28);

                    }
                    PlayerPrefs.SetInt("levelSelected", 28);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(true);
                    Level14.SetActive(false);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 28:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 29);

                    }
                    PlayerPrefs.SetInt("levelSelected", 29);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(true);
                    Level15.SetActive(false);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 29:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 30);

                    }
                    PlayerPrefs.SetInt("levelSelected", 30);
                    Debug.Log("5");
                    adHelper++;

                    // fireWorks.enableEmission = true;
                    Level1.SetActive(false);
                    Level2.SetActive(false);
                    Level3.SetActive(false);
                    Level4.SetActive(false);
                    Level5.SetActive(false);
                    Level6.SetActive(false);
                    Level7.SetActive(false);
                    Level8.SetActive(false);
                    Level9.SetActive(false);
                    Level10.SetActive(false);
                    Level11.SetActive(false);
                    Level12.SetActive(false);
                    Level13.SetActive(false);
                    Level14.SetActive(false);
                    Level15.SetActive(true);

                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    LoadGame();
                    winLevel4part.winHelper = 0;

                }
                break;
            case 30:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && winLevel4part.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 31);

                    }
                    PlayerPrefs.SetInt("levelSelected", 31);
                    Debug.Log("5");
                    // fireWorks.enableEmission = true;


                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    part4.locked4 = false;

                    winLevel4part.winHelper = 0;
                    SceneManager.LoadScene("5tike");
                    //SceneManager.LoadScene("Menu");


                }
                break;
        }
    }

    void LoadGame()
    {
        selectedLevelNumber = PlayerPrefs.GetInt("levelSelected", 1);
        LevelNumber = PlayerPrefs.GetInt("LevelNumber", 1);

    }

    public static void lockPart1()
    {
        part1.touchLockPart1 = false;
        part2.touchLockPart2 = true;
        part3.touchLockPart3 = true;
        part4.touchLockPart4 = true;



        part2.colliderHelper = false;
        part3.colliderHelper = false;
        part4.colliderHelper = false;

    }
    public static void lockPart2()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = false;
        part3.touchLockPart3 = true;
        part4.touchLockPart4 = true;


        part1.colliderHelper = false;
        part3.colliderHelper = false;
        part4.colliderHelper = false;

    }
    public static void lockPart3()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = true;
        part3.touchLockPart3 = false;
        part4.touchLockPart4 = true;


        part1.colliderHelper = false;
        part2.colliderHelper = false;
        part4.colliderHelper = false;

    }
    public static void lockPart4()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = true;
        part3.touchLockPart3 = true;
        part4.touchLockPart4 = false;


        part1.colliderHelper = false;
        part2.colliderHelper = false;
        part3.colliderHelper = false;

    }
    public static void unlockParts()
    {
        part1.touchLockPart1 = false;
        part2.touchLockPart2 = false;
        part3.touchLockPart3 = false;
        part4.touchLockPart4 = false;


        part1.colliderHelper = true;
        part2.colliderHelper = true;
        part3.colliderHelper = true;
        part4.colliderHelper = true;



    }

    public void pauseSelected()
    {
        PauseAudioSource.Play();
        pause.interactable = false;
        pausePanel.gameObject.SetActive(true);
        Panel_Animator.SetTrigger("PanelShow");
        winLevel4part.pauseHelper = 1;
        part1.locked1 = true;
        part2.locked2 = true;
        part3.locked3 = true;
        part4.locked4 = true;


    }

    public void resumeSelected()
    {
        pause.interactable = true;
        ResumeAudioSource.Play();
        Panel_Animator.SetTrigger("PanelHide");
        //pausePanel.gameObject.SetActive(false);
        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        part4.locked4 = false;

        winLevel4part.pauseHelper = 0;
    }

    public void backToMenu()
    {
        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        part4.locked4 = false;
        SceneManager.LoadScene("Menu");

    }
}



