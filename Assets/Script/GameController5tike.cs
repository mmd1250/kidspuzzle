using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TapsellSDK;


public class GameController5tike : MonoBehaviour
{
    private int LevelNumber;
    private int selectedLevelNumber;
    string tapsellKey = "rahqjisrhsmpfapomoqsrfjefaoqcparseaqqscfndfgskootkcdjmsjbicibbsaaapacs";

    int initialAdHelper;

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;


    public Animator Panel_Animator;

    public Text starNumber;
    int tapsellHelper;  // for avalabing ad


    public Sprite soundOn;
    public Sprite soundOff;
    public Button sound;
    public static int adHelper;

    public static AudioClip lockPart;

    public static int TouchHelper;
    public static int pauseHelper; // for disabaling pause during win animation


    public Button pause;

    public GameObject pausePanel;
    string zoneId = "606ae81114e5b90001c817c0";
    public static TapsellAd ad;
    TapsellShowOptions showOptions = new TapsellShowOptions();



    public AudioSource PanelExitAudioSoure;
    public AudioSource ResumeAudioSoure;

    // public ParticleSystem fireWorks;

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
        request();

        starNumber.text = PlayerPrefs.GetInt("Star", 0).ToString();

        if (PlayerPrefs.GetInt("sound", 1) == 1) // 1 mean on, 0 mean off
        {
            AudioListener.volume = 1;
            //sound.GetComponent<Image>().sprite = soundOn;

        }
        if (PlayerPrefs.GetInt("sound", 1) == 0) // 1 mean on, 0 mean off
        {
            AudioListener.volume = 0;
            //sound.GetComponent<Image>().sprite = soundOff;


        }
        part1.locked1 = true;
        part2.locked2 = true;
        part3.locked3 = true;
        part4.locked4 = true;
        part5.locked5 = true;

        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        part4.locked4 = false;
        part5.locked5 = false;

        TouchHelper = 0;
        // PlayerPrefs.DeleteAll(); // for test

        //LevelNumber = PlayerPrefs.GetInt("LevelNumber", 16);
        //selectedLevelNumber = PlayerPrefs.GetInt("levelSelected", 16);


        pausePanel.gameObject.SetActive(false);
        selectedLevelNumber = PlayerPrefs.GetInt("levelSelected", 31);

        switch (selectedLevelNumber)
        {
            case 31:
                Level1.SetActive(true);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);
                break;

            case 32:
                Level1.SetActive(false);
                Level2.SetActive(true);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(false);

                break;
            case 33:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(true);
                Level4.SetActive(false);
                Level5.SetActive(false);

                break;
            case 34:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(true);
                Level5.SetActive(false);

                break;
            case 35:
                Level1.SetActive(false);
                Level2.SetActive(false);
                Level3.SetActive(false);
                Level4.SetActive(false);
                Level5.SetActive(true);

                break;
        }

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

        if (adHelper >= 4 && PlayerPrefs.GetInt("ads", 1) == 1 && tapsellHelper == 1)
        {
            showads();
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

            case 31:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && part5.locked5 && winLevel5part.winHelper == 1)
                {
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 32);

                        Level1.SetActive(false);
                        Level2.SetActive(true);
                        Level3.SetActive(false);
                        Level4.SetActive(false);
                        Level5.SetActive(false);



                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                        part2.locked2 = false;
                        part3.locked3 = false;
                        part4.locked4 = false;
                        part5.locked5 = false;


                        LoadGame();
                        winLevel5part.winHelper = 0;
 
                }
                break;
            case 32:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && part5.locked5 && winLevel5part.winHelper == 1)
                {
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 33);

                        Level1.SetActive(false);
                        Level2.SetActive(false);
                        Level3.SetActive(true);
                        Level4.SetActive(false);
                        Level5.SetActive(false);


                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                        part2.locked2 = false;
                        part3.locked3 = false;
                        part4.locked4 = false;
                        part5.locked5 = false;


                        LoadGame();
                        winLevel5part.winHelper = 0;
                    
                }
                  break;
            case 33:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && part5.locked5 && winLevel5part.winHelper == 1)
                {
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 34);

                        Level1.SetActive(false);
                        Level2.SetActive(false);
                        Level3.SetActive(false);
                        Level4.SetActive(true);
                        Level5.SetActive(false);


                    pauseHelper = 0;
                    pause.interactable = true;
                    part1.locked1 = false;
                        part2.locked2 = false;
                        part3.locked3 = false;
                        part4.locked4 = false;
                        part5.locked5 = false;


                        LoadGame();
                        winLevel5part.winHelper = 0;
                    
                }
                break;
            case 34:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && part5.locked5 && winLevel5part.winHelper == 1)
                {
                    adHelper++;

                    PlayerPrefs.SetInt("levelSelected", 35);

                        Level1.SetActive(false);
                        Level2.SetActive(false);
                        Level3.SetActive(false);
                        Level4.SetActive(false);
                        Level5.SetActive(true);

                    pauseHelper = 0;
                    pause.interactable = true;

                        part1.locked1 = false;
                        part2.locked2 = false;
                        part3.locked3 = false;
                        part4.locked4 = false;
                        part5.locked5 = false;


                        LoadGame();
                        winLevel5part.winHelper = 0;
                    
                }
                break;
            case 35:
                if (part1.locked1 && part2.locked2 && part3.locked3 && part4.locked4 && part5.locked5 && winLevel5part.winHelper == 1)
                {
                    pauseHelper = 0;
                    pause.interactable = true;
                    SceneManager.LoadScene("Menu");

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
        part5.touchLockPart5 = true;




        part2.colliderHelper = false;
        part3.colliderHelper = false;
        part4.colliderHelper = false;
        part5.colliderHelper = false;

    }
    public static void lockPart2()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = false;
        part3.touchLockPart3 = true;
        part4.touchLockPart4 = true;
        part5.touchLockPart5 = true;



        part1.colliderHelper = false;
        part3.colliderHelper = false;
        part4.colliderHelper = false;
        part5.colliderHelper = false;


    }
    public static void lockPart3()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = true;
        part3.touchLockPart3 = false;
        part4.touchLockPart4 = true;
        part5.touchLockPart5 = true;



        part1.colliderHelper = false;
        part2.colliderHelper = false;
        part4.colliderHelper = false;
        part5.colliderHelper = false;


    }
    public static void lockPart4()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = true;
        part3.touchLockPart3 = true;
        part4.touchLockPart4 = false;
        part5.touchLockPart5 = true;


        part1.colliderHelper = false;
        part2.colliderHelper = false;
        part3.colliderHelper = false;
        part5.colliderHelper = false;
    }
    public static void lockPart5()
    {
        part1.touchLockPart1 = true;
        part2.touchLockPart2 = true;
        part3.touchLockPart3 = true;
        part4.touchLockPart4 = true;
        part5.touchLockPart5 = false;


        part1.colliderHelper = false;
        part2.colliderHelper = false;
        part3.colliderHelper = false;
        part4.colliderHelper = false;
    }
    public static void unlockParts()
    {
        part1.touchLockPart1 = false;
        part2.touchLockPart2 = false;
        part3.touchLockPart3 = false;
        part4.touchLockPart4 = false;
        part5.touchLockPart5 = false;



        part1.colliderHelper = true;
        part2.colliderHelper = true;
        part3.colliderHelper = true;
        part4.colliderHelper = true;
        part5.colliderHelper = true;


    }

    public void pauseSelected()
    {
        PanelExitAudioSoure.Play();
        pause.interactable = false;
        pausePanel.gameObject.SetActive(true);
        Panel_Animator.SetTrigger("PanelShow");
        winLevel5part.pauseHelper = 1;
        part1.locked1 = true;
        part2.locked2 = true;
        part3.locked3 = true;
        part4.locked4 = true;
        part5.locked5 = true;


    }

    public void resumeSelected()
    {
        ResumeAudioSoure.Play();
        pause.interactable = true;
        Panel_Animator.SetTrigger("PanelHide");
        //pausePanel.gameObject.SetActive(false);
        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        part4.locked4 = false;
        part5.locked5 = false;


        winLevel5part.pauseHelper = 0;
    }

    public void backToMenu()
    {
        part1.locked1 = false;
        part2.locked2 = false;
        part3.locked3 = false;
        part4.locked4 = false;
        part5.locked5 = false;
        SceneManager.LoadScene("Menu");

    }
}
