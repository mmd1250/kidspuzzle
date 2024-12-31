using CafeBazaar.Billing;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TapsellSDK;


public class levelChooser : MonoBehaviour
{
    private int LevelNumber;

    #region   //level button
    public Button lvl1;
    public Button lvl2;
    public Button lvl3;
    public Button lvl4;
    public Button lvl5;
    public Button lvl6;
    public Button lvl7;
    public Button lvl8;
    public Button lvl9;
    public Button lvl10;
    public Button lvl11;
    public Button lvl12;
    public Button lvl13;
    public Button lvl14;
    public Button lvl15;
    public Button lvl16;
    public Button lvl17;
    public Button lvl18;
    public Button lvl19;
    public Button lvl20;
    public Button lvl21;
    public Button lvl22;
    public Button lvl23;
    public Button lvl24;
    public Button lvl25;
    public Button lvl26;
    public Button lvl27;
    public Button lvl28;
    public Button lvl29;
    public Button lvl30;
    public Button lvl31;
    public Button lvl32;
    public Button lvl33;
    public Button lvl34;
    public Button lvl35;

    #endregion


    public Button Right1;
    public Button Right2;
    public Button Right3;

    public Button Left1;
    public Button Left2;
    public Button Left3;

    //Dino pack helper
    public Image Filter;
    public Image dialogeBoxStar;
    public Button yesStar;
    public Button noStar;
    public Button unLock;

    public Text starNumber;

    public AudioClip lockSound;
    public AudioClip buySound;
    public AudioClip getStarSound;

    //public Image lock1;
    //public Image lock2;
    //public Image lock3;
    //public Image lock4;
    //public Image lock5;
    string iapid = "star1";
    string unlock = "unlock";


    string zoneId = "int";






    // Start is called before the first frame update
    public void Start()
    {
        //PlayerPrefs.SetInt("BonusLock", 0); for test


        Filter.gameObject.SetActive(false);
        dialogeBoxStar.gameObject.SetActive(false);
        yesStar.gameObject.SetActive(false);
        noStar.gameObject.SetActive(false);

        //levels initial
        if (Menu.level == 1)
        {


            //Tapsell.RequestAd(zoneId, true, );



            lvl1.interactable = false;
            lvl2.interactable = false;
            lvl3.interactable = false;
            lvl4.interactable = false;
            lvl5.interactable = false;
            lvl6.interactable = false;
            lvl7.interactable = false;
            lvl8.interactable = false;
            lvl9.interactable = false;
            lvl10.interactable = false;
            lvl11.interactable = false;
            lvl12.interactable = false;
            lvl13.interactable = false;
            lvl14.interactable = false;
            lvl15.interactable = false;



            Left1.interactable = false;
            Right1.interactable = true;

            LevelNumber = PlayerPrefs.GetInt("LevelNumber", 1);
            switch (LevelNumber)
            {
                case 1:

                    lvl1.interactable = true;

                    break;

                case 2:
                    lvl1.interactable = true;
                    lvl2.interactable = true;


                    break;

                case 3:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;


                    break;

                case 4:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;


                    break;

                case 5:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;


                    break;
                case 6:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;


                    break;
                case 7:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;


                    break;
                case 8:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;


                    break;
                case 9:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;


                    break;
                case 10:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;


                    break;
                case 11:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;


                    break;
                case 12:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;


                    break;
                case 13:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;


                    break;
                case 14:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;


                    break;
                case 15:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;

                    break;
                case 16:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 17:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 18:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 19:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 20:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 21:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 22:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 23:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 24:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 25:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 26:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 27:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 28:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 29:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 30:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 31:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 32:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 33:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 34:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;
                case 35:
                    lvl1.interactable = true;
                    lvl2.interactable = true;
                    lvl3.interactable = true;
                    lvl4.interactable = true;
                    lvl5.interactable = true;
                    lvl6.interactable = true;
                    lvl7.interactable = true;
                    lvl8.interactable = true;
                    lvl9.interactable = true;
                    lvl10.interactable = true;
                    lvl11.interactable = true;
                    lvl12.interactable = true;
                    lvl13.interactable = true;
                    lvl14.interactable = true;
                    lvl15.interactable = true;


                    break;

            }
        }

        if (Menu.level ==2)
        {
            lvl16.interactable = false;
            lvl17.interactable = false;
            lvl18.interactable = false;
            lvl19.interactable = false;
            lvl20.interactable = false;
            lvl21.interactable = false;
            lvl22.interactable = false;
            lvl23.interactable = false;
            lvl24.interactable = false;
            lvl25.interactable = false;
            lvl26.interactable = false;
            lvl27.interactable = false;
            lvl28.interactable = false;
            lvl29.interactable = false;
            lvl30.interactable = false;

            Left2.interactable = true;
            Right2.interactable = true;

            LevelNumber = PlayerPrefs.GetInt("LevelNumber", 1);
            switch (LevelNumber)
            {
                case 1:

                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;
                    break;

                case 2:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;

                case 3:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;

                case 4:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;

                case 5:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 6:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 7:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 8:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 9:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 10:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 11:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 12:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 13:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 14:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 15:
                    lvl16.interactable = false;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 16:

                    lvl16.interactable = true;
                    lvl17.interactable = false;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;

                    break;
                case 17:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = false;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 18:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = false;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;

                    break;
                case 19:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = false;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 20:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = false;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 21:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = false;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 22:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = false;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 23:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = false;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 24:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = false;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;

                    break;
                case 25:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = false;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 26:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = false;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 27:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = false;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 28:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = false;
                    lvl30.interactable = false;


                    break;
                case 29:

                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = true;
                    lvl30.interactable = false;


                    break;
                case 30:
                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = true;
                    lvl30.interactable = true;


                    break;
                case 31:
                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = true;
                    lvl30.interactable = true;


                    break;
                case 32:
                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = true;
                    lvl30.interactable = true;


                    break;
                case 33:
                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = true;
                    lvl30.interactable = true;


                    break;
                case 34:
                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = true;
                    lvl30.interactable = true;


                    break;
                case 35:
                    lvl16.interactable = true;
                    lvl17.interactable = true;
                    lvl18.interactable = true;
                    lvl19.interactable = true;
                    lvl20.interactable = true;
                    lvl21.interactable = true;
                    lvl22.interactable = true;
                    lvl23.interactable = true;
                    lvl24.interactable = true;
                    lvl25.interactable = true;
                    lvl26.interactable = true;
                    lvl27.interactable = true;
                    lvl28.interactable = true;
                    lvl29.interactable = true;
                    lvl30.interactable = true;


                    break;


            }

        }

        if (Menu.level == 3)
        {
            starNumber.text = PlayerPrefs.GetInt("Star", 0).ToString();

            if(PlayerPrefs.GetInt("BonusLock", 1) ==1)
            {
                lvl31.interactable = false;
                lvl32.interactable = false;
                lvl33.interactable = false;
                lvl34.interactable = false;
                lvl35.interactable = false;
                unLock.gameObject.SetActive(true);

            }
            else
            {
                lvl31.interactable = true;
                lvl32.interactable = true;
                lvl33.interactable = true;
                lvl34.interactable = true;
                lvl35.interactable = true;
                unLock.gameObject.SetActive(false);
            }


            Left3.interactable = true;
            Right3.interactable = false;

            LevelNumber = PlayerPrefs.GetInt("LevelNumber", 1);

        }


        //PlayerPrefs.DeleteAll();

    }


    public void level1Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 1);
        SceneManager.LoadScene("SampleScene");

    }    
    public void level2Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 2);
        SceneManager.LoadScene("SampleScene");

    }    
    public void level3Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 3);
        SceneManager.LoadScene("SampleScene");

    }    
    public void level4Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 4);
        SceneManager.LoadScene("SampleScene");

    }   
    public void level5Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 5);
        SceneManager.LoadScene("SampleScene");

    }
    public void level6Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 6);
        SceneManager.LoadScene("SampleScene");

    }
    public void level7Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 7);
        SceneManager.LoadScene("SampleScene");

    }
    public void level8Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 8);
        SceneManager.LoadScene("SampleScene");

    }
    public void level9Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 9);
        SceneManager.LoadScene("SampleScene");

    }
    public void level10Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 10);
        SceneManager.LoadScene("SampleScene");

    }
    public void level11Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 11);
        SceneManager.LoadScene("SampleScene");

    }
    public void level12Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 12);
        SceneManager.LoadScene("SampleScene");

    }
    public void level13Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 13);
        SceneManager.LoadScene("SampleScene");

    }
    public void level14Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 14);
        SceneManager.LoadScene("SampleScene");

    }
    public void level15Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 15);
        SceneManager.LoadScene("SampleScene");

    }
    public void level16Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 16);
        SceneManager.LoadScene("4tike");

    }
    public void level17Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 17);
        SceneManager.LoadScene("4tike");

    }
    public void level18Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 18);
        SceneManager.LoadScene("4tike");

    }
    public void level19Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 19);
        SceneManager.LoadScene("4tike");

    }
    public void level20Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 20);
        SceneManager.LoadScene("4tike");

    }
    public void level21Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 21);
        SceneManager.LoadScene("4tike");

    }
    public void level22Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 22);
        SceneManager.LoadScene("4tike");

    }
    public void level23Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 23);
        SceneManager.LoadScene("4tike");

    }
    public void level24Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 24);
        SceneManager.LoadScene("4tike");

    }
    public void level25Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 25);
        SceneManager.LoadScene("4tike");

    }
    public void level26Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 26);
        SceneManager.LoadScene("4tike");

    }
    public void level27Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 27);
        SceneManager.LoadScene("4tike");

    }
    public void level28Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 28);
        SceneManager.LoadScene("4tike");

    }
    public void level29Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 29);
        SceneManager.LoadScene("4tike");

    }
    public void level30Selected()
    {
        PlayerPrefs.SetInt("levelSelected", 30);
        SceneManager.LoadScene("4tike");

    }
    public void level31Selected()
    {

            PlayerPrefs.SetInt("levelSelected", 31);
            SceneManager.LoadScene("5tike");
        
    }
    public void level32Selected()
    {

            PlayerPrefs.SetInt("levelSelected", 32);
            SceneManager.LoadScene("5tike");
        
    }
    public void level33Selected()
    {

            PlayerPrefs.SetInt("levelSelected", 33);
            SceneManager.LoadScene("5tike");
        
    }
    public void level34Selected()
    {

            PlayerPrefs.SetInt("levelSelected", 34);
            SceneManager.LoadScene("5tike");
        

    }
    public void level35Selected()
    {

            PlayerPrefs.SetInt("levelSelected", 35);
            SceneManager.LoadScene("5tike");
        

    }
    public void unlockPuzzle()
    {
        unLock.gameObject.SetActive(false);

        dialogeBoxStar.gameObject.SetActive(true);
        yesStar.gameObject.SetActive(true);
        noStar.gameObject.SetActive(true);

    }
    // Update is called once per frame

    public void buyPuzzle()
    {
        BazaarBilling.Purchase(unlock, (result) =>
        {
            if (result.Successful)
            {
                Purchase purchase = result.Body;
                PlayerPrefs.SetInt("BonusLock", 0);
                Debug.Log("Purchase info :");
                Debug.Log("   ProductId         : " + purchase.ProductId);
                Debug.Log("   OrderId           : " + purchase.OrderId);
                Debug.Log("   PurchaseToken     : " + purchase.PurchaseToken);
                Debug.Log("   PurchaseTime      : " + purchase.PurchaseTime);
                Debug.Log("   DeveloperPayload  : " + purchase.DeveloperPayload);
                Debug.Log("   State             : " + purchase.State.ToString());
                Debug.Log("   ProductType       : " + purchase.ProductType.ToString());
                unLock.gameObject.SetActive(false);
                lvl31.interactable = true;
                lvl32.interactable = true;
                lvl33.interactable = true;
                lvl34.interactable = true;
                lvl35.interactable = true;
            }
            else
            {
                Debug.Log("Purchase Failed :" + result.Message);
                unLock.gameObject.SetActive(true);
                lvl31.interactable = false;
                lvl32.interactable = false;
                lvl33.interactable = false;
                lvl34.interactable = false;
                lvl35.interactable = false;
            }

        });
        // IAP proccess
        //if success
        //PlayerPrefs.SetInt("Star", PlayerPrefs.GetInt("Star", 0) + 1500);
        
        BazaarBilling.Consume(unlock, (result) =>
        {
            if (result.Successful)
            {

                Debug.Log("Consume OK");
            }
            else
            {
                Debug.Log("Consume Failed");
            }

        });

        Filter.gameObject.SetActive(false);
        dialogeBoxStar.gameObject.SetActive(false);
        yesStar.gameObject.SetActive(false);
        noStar.gameObject.SetActive(false);



    }
    public void noBuyPuzzle()
    {
        Filter.gameObject.SetActive(false);
        dialogeBoxStar.gameObject.SetActive(false);
        yesStar.gameObject.SetActive(false);
        noStar.gameObject.SetActive(false);
    }


}

