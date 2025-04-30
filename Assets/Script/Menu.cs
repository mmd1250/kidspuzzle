using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CafeBazaar.Billing;
//using TapsellSDK;


public class Menu : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject Star_Particle;
    public GameObject mainMenu;
    public GameObject LevelPages;
    public GameObject levelSelected3tike;
    public GameObject levelSelected4tike;
    public GameObject levelSelectedDino;

    public Button sound;
    public Button adsButton;

    public Sprite soundOn;
    public Sprite soundOff;
    public static int level;

    public GameObject PlayBtn;
    public levelChooser lv3tike;
    public levelChooser lv4tike;
    public levelChooser lvDino;
    //public GameObject 

    //string iapAds = "ads";
    //string tapsellKey = "rahqjisrhsmpfapomoqsrfjefaoqcparseaqqscfndfgskootkcdjmsjbicibbsaaapacs";
    //string zoneID = "606ae81114e5b90001c817c0";
    //public TapsellAd Ad;



    // Start is called before the first frame update
    void Start()
    {
        //if(PlayerPrefs.GetInt("ads", 0) ==1)  0 mean off, 1 mean on
        //{

            //Tapsell.Initialize(tapsellKey);
        //}

        //PlayerPrefs.DeleteAll();
        // RequestIntersitialBanner();


        //Tapsell.RequestAd(zoneID, true, <TapsellAd> "ad");





        if (PlayerPrefs.GetInt("sound", 1) == 1) // 1 mean on, 0 mean off
        {
            AudioListener.volume = 1;
            //sound.GetComponent<Image>().sprite = soundOn;
            Debug.Log("seda one");

        }
        if (PlayerPrefs.GetInt("sound", 1) == 0) // 1 mean on, 0 mean off
        {
            AudioListener.volume = 0;
            //sound.GetComponent<Image>().sprite = soundOff;
            Debug.Log("off boda");


        }
        /*PlayerPrefs.GetInt("ads", 1); // 1 mean ads are enable, 0 means ads are disable

       if(PlayerPrefs.GetInt("ads",1)== 1)
        {
            adsButton.gameObject.SetActive(true);
        }
        if (PlayerPrefs.GetInt("ads", 1) == 0)
        {
            adsButton.gameObject.SetActive(false);
        }*/
        //AudioListener.volume = 0;
        //PlayerPrefs.DeleteAll(); // for test
        level = 0; //0 mean menu, 1 mean 3 tike, 2 mean 4 tike, 3 mean dino

     //   mainMenu.GetComponent<Canvas>().enabled = true;
      //  levelSelected.GetComponent<Canvas>().enabled = false;
    }

    /*public void noAds()
    {
        BazaarBilling.Purchase(iapAds, (result) =>
        {
            if (result.Successful)
            {
                Purchase purchase = result.Body;
                PlayerPrefs.SetInt("ads", 0);
                adsButton.gameObject.SetActive(false);
                Debug.Log("Purchase info :");
                Debug.Log("   ProductId         : " + purchase.ProductId);
                Debug.Log("   OrderId           : " + purchase.OrderId);
                Debug.Log("   PurchaseToken     : " + purchase.PurchaseToken);
                Debug.Log("   PurchaseTime      : " + purchase.PurchaseTime);
                Debug.Log("   DeveloperPayload  : " + purchase.DeveloperPayload);
                Debug.Log("   State             : " + purchase.State.ToString());
                Debug.Log("   ProductType       : " + purchase.ProductType.ToString());

            }
            else
            {
                Debug.Log("Purchase Failed :" + result.Message);
            }

        });


    }*/

    public void levelSelected3tikeUI()
    {
        level = 1;
        Debug.Log("next  shod");
        Star_Particle.SetActive(false);
        mainMenu.SetActive(false);
        PlayBtn.SetActive (false);
        LevelPages.SetActive(true);
        //levelSelected3tike.SetActive(true);
        lv3tike.Start();
        audioSource.Play();

    }
    public void MainMenu()
    {
        Star_Particle.SetActive(true);
        mainMenu.SetActive(true);
        LevelPages.SetActive(false);
        PlayBtn.SetActive(true);
        //levelSelected3tike.SetActive(false);
        //levelSelected4tike.SetActive(false);
        //levelSelectedDino.SetActive(false);



    }
    public void Next3be4()
    {
        if(level ==1)
        {
            Debug.Log("next zade shod");
            levelSelected3tike.SetActive(false);
            levelSelected4tike.SetActive(true);
            levelSelectedDino.SetActive(false);

            lv4tike.Start();


            level = 2;
        }

    }
    public void Next4beDino()
    {

        if (level == 2)
        {
            levelSelected3tike.SetActive(false);
            levelSelected4tike.SetActive(false);
            levelSelectedDino.SetActive(true);
            lvDino.Start();

            level = 3;
        }

    }
    public void backDinobe4()
    {
        if (level == 3)
        {
            levelSelected3tike.SetActive(false);
            levelSelected4tike.SetActive(true);
            levelSelectedDino.SetActive(false);
            lv4tike.Start();

            level = 2;
        }


    }
    public void back4be3()
    {

        if (level == 2)
        {
            levelSelected3tike.SetActive(true);
            levelSelected4tike.SetActive(false);
            levelSelectedDino.SetActive(false);
            lv3tike.Start();

            level = 1;
        }

    }

    public void Update()
    {
        //Debug.Log(PlayerPrefs.GetInt("sound", 1));
    }
    public void soundOnOff()
    {
        if(PlayerPrefs.GetInt("sound",1) == 1) // 1 mean on, 0 mean off
        {
            PlayerPrefs.SetInt("sound", 0);
            
            AudioListener.volume = 0;
            sound.GetComponent<Image>().sprite = soundOff;

            return;
        }
        if (PlayerPrefs.GetInt("sound", 1) == 0) // 1 mean on, 0 mean off
        {
            PlayerPrefs.SetInt("sound", 1);
            AudioListener.volume = 1;
            sound.GetComponent<Image>().sprite = soundOn;

            return;
        }
    }
}
