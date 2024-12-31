using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TapsellSDK;



public class GameController : MonoBehaviour
{
    string tapsellKey = "rahqjisrhsmpfapomoqsrfjefaoqcparseaqqscfndfgskootkcdjmsjbicibbsaaapacs";

    int initialAdHelper; 
    private int LevelNumber;
    private int selectedLevelNumber;
    int tapsellHelper;  // for avalabing ad

    public Sprite soundOn;
    public Sprite soundOff;
    public Button sound;


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
    public Text starNumber;

    public static int adHelper;

    public static AudioClip lockPart;

    string zoneId = "606ae81114e5b90001c817c0";
    public static TapsellAd ad;
    TapsellShowOptions showOptions = new TapsellShowOptions();


    public Button pause;

    public GameObject pausePanel; 


    public static int TouchHelper;
    public static int pauseHelper; // for disabaling pause during win animation
    //public ParticleSystem fireWorks;

    public void request()
    {
        Tapsell.RequestAd(zoneId, false,
             (TapsellAd result) => {
                 // onAdAvailable
                 Debug.Log("on Ad Available");
                 ad = result;
                 tapsellHelper = 1;
             },

             (string zoneId) => {
                 // onNoAdAvailable
                 Debug.Log("no Ad Available");
                 tapsellHelper = 0;

             },

             (TapsellError error) => {
                 // onError
                 Debug.Log(error.message);
                 tapsellHelper = 0;

             },

             (string zoneId) => {
                 // onNoNetwork
                 Debug.Log("no Network");
                 tapsellHelper = 0;

             },

             (TapsellAd result) => {
                 // onExpiring
                 Debug.Log("expiring");
             },

             (TapsellAd result) => {
                 // onOpen
                 Debug.Log("open");
             },

             (TapsellAd result) => {
                 // onClose
                 Debug.Log("close");
             }

           );
    }
    public void showads()
    {
        showOptions.backDisabled = false;
        showOptions.immersiveMode = false;
        showOptions.rotationMode = TapsellShowOptions.ROTATION_UNLOCKED;
        showOptions.showDialog = true;
        //showOptions.setRotationMode(ROTATION_MODE);

        Tapsell.ShowAd(ad, zoneId);
    }
    // Start is called before the first frame update
    void Start()
    {
        initialAdHelper = 1;
        pauseHelper = 0;
        adHelper = 0;
        // starAnim.gameObject.SetActive(true);
        request();
        //starAnim.enabled = true;
        if (PlayerPrefs.GetInt("sound", 1) == 1) // 1 mean on, 0 mean off
        {
            AudioListener.volume = 1;
            sound.GetComponent<Image>().sprite = soundOn;

        }
        if (PlayerPrefs.GetInt("sound", 1) == 0) // 1 mean on, 0 mean off
        {
            AudioListener.volume = 0;
            sound.GetComponent<Image>().sprite = soundOff;


        }

        starNumber.text = PlayerPrefs.GetInt("Star", 0).ToString();
        part1.locked1 = true;
        part2.locked2 = true;
        part3.locked3 = true;
        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        TouchHelper = 0;
        //PlayerPrefs.DeleteAll(); // for test
       // PlayerPrefs.SetInt("LevelNumber", 20);
        LevelNumber = PlayerPrefs.GetInt("LevelNumber", 1);
        selectedLevelNumber = PlayerPrefs.GetInt("levelSelected", 1);

        Debug.Log("level selected start" + selectedLevelNumber);
        Debug.Log("level number start" + LevelNumber);

        pausePanel.gameObject.SetActive(false);
        switch (selectedLevelNumber)
        {
            
            case 1:
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

            case 2:
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

            case 3:
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

            case 4:
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

            case 5:
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
            case 6:
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
            case 7:
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
            case 8:
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
            case 9:
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
            case 10:
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
            case 11:
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
            case 12:
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
            case 13:
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
            case 14:
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
            case 15:
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
        request();

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

        if (adHelper >= 5 && PlayerPrefs.GetInt("ads", 1) == 1 && tapsellHelper ==1)
        {
            showads();
            adHelper = 0;
            StartCoroutine(reqad());

        }
        if(pauseHelper ==1)
        {
            pause.interactable = false;
        }

        Debug.Log("level selected update" + selectedLevelNumber);
        Debug.Log("level number update" + LevelNumber);
        switch (selectedLevelNumber)
        {
            
            case 1:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper ==1)
                {
                    if(selectedLevelNumber == LevelNumber)
                    {

                        PlayerPrefs.SetInt("LevelNumber", 2);
                        Debug.Log("ezafe shod");
                    }

                    PlayerPrefs.SetInt("levelSelected", 2);
                    adHelper++;
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
                    LoadGame();
                    winLevel.winHelper = 0;
                    winLevel.starHelper = 1;
                }
                break;
            case 2:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 3);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 3);
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


                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    pauseHelper = 0;
                    pause.interactable = true;
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 3:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 4);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 4);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 4:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 5);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 5);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 5:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 6);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 6);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;

            case 6:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 7);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 7);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 7:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 8);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 8);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 8:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 9);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 9);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 9:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 10);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 10);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 10:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 11);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 11);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 11:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 12);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 12);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 12:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 13);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 13);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 13:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 14);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 14);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 14:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 15);
                        Debug.Log("ezafe shod");

                    }
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 15);
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
                    LoadGame();
                    winLevel.winHelper = 0;

                }
                break;
            case 15:
                if (part1.locked1 && part2.locked2 && part3.locked3 && winLevel.winHelper == 1)
                {
                    if (selectedLevelNumber == LevelNumber)
                    {
                        PlayerPrefs.SetInt("LevelNumber", 16);
                        Debug.Log("ezafe shod");

                    }
                    PlayerPrefs.SetInt("levelSelected", 16);
                    // fireWorks.enableEmission = true;


                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                    part2.locked2 = false;
                    part3.locked3 = false;
                    winLevel.winHelper = 0;

                    SceneManager.LoadScene("4tike");
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


        part2.colliderHelper = false;
        part3.colliderHelper = false;
    }
    public static void lockPart2()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = false;
        part3.touchLockPart3 = true;

        part1.colliderHelper = false;
        part3.colliderHelper = false;
    }
    public static void lockPart3()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = true;
        part3.touchLockPart3 = false;

        part1.colliderHelper = false;
        part2.colliderHelper = false;
    }
    public static void unlockParts()
    {
        part1.touchLockPart1 = false;
        part2.touchLockPart2 = false;
        part3.touchLockPart3 = false;

        part1.colliderHelper = true;
        part2.colliderHelper = true;
        part3.colliderHelper = true;


    }

    public void pauseSelected()
    {
        pause.interactable = false;
        pausePanel.gameObject.SetActive(true);
        winLevel.pauseHelper = 1;
        part1.locked1 = true;
        part2.locked2 = true;
        part3.locked3 = true;


    }

    public void resumeSelected()
    {
        pause.interactable = true;
        pausePanel.gameObject.SetActive(false);
        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        winLevel.pauseHelper = 0;

    }

    public void backToMenu()
    {
        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        winLevel.pauseHelper = 0;


        StartCoroutine(menu());


    }
    IEnumerator menu()
    {

        yield return new WaitForSeconds(0.1f);
        SceneManager.LoadScene("Menu");

    }

}



