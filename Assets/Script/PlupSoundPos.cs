using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class PlupSoundPos : MonoBehaviour
{
    private int SwitchStatus = 1;
    public GameObject PlupSwitchButton;
    public AudioSource EnterPanelSound;
    public AudioSource ResumeSound;
    // Start is called before the first frame update
    void Start()
    {
        // ?????? ????? ????????? (??? ???? ?????? ????? ????? ??????? 1 ???)
        int soundSetting = PlayerPrefs.GetInt("PlupSound", 1);
        // ????? ????? ?????????
        ResumeSound.volume = soundSetting == 1 ? 1 : 0;
        EnterPanelSound.volume = soundSetting == 1 ? 1 : 0;
        // ????? ?????? ???? ????? ?? ???? ????? ?????????
        PlupSwitchButton.transform.localPosition = new Vector3(soundSetting == 1 ? 90 : -90, PlupSwitchButton.transform.localPosition.y, 0);

        // ????? SwitchStatus ?? ?? ?????? ????
        SwitchStatus = soundSetting == 1 ? 1 : -1;



        if (PlayerPrefs.GetInt("PlupSound", 1) == 1) // 1 mean on, 0 mean off
        {
            ResumeSound.volume = 1;
            EnterPanelSound.volume = 1;
            //sound.GetComponent<Image>().sprite = soundOn;

        }
        if (PlayerPrefs.GetInt("PlupSound", 1) == 0) // 1 mean on, 0 mean off
        {
            ResumeSound.volume = 0;
            EnterPanelSound.volume = 0;
            //sound.GetComponent<Image>().sprite = soundOff;


        }
    }



    public void SwitchSoundButtonClick()
    {
        //SwitchButton.transform.localPosition = new Vector3(-SwitchButton.transform.localPosition.x,SwitchButton.transform.localPosition.y,0);
        PlupSwitchButton.transform.DOLocalMoveX(-PlupSwitchButton.transform.localPosition.x, 0.5f);
        SwitchStatus = (int)Mathf.Sign(-PlupSwitchButton.transform.localPosition.x);
        Debug.Log("Plup switch status = " + SwitchStatus);
        if (SwitchStatus == 1)
        {
            ResumeSound.volume = 1;
            EnterPanelSound.volume = 1;
            PlayerPrefs.SetInt("PlupSound", 1);
        }
        else if (SwitchStatus == -1)
        {
            ResumeSound.volume = 0;
            EnterPanelSound.volume = 0;
            PlayerPrefs.SetInt("PlupSound", 0);
        }
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
