using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class SoundSwipeMenu : MonoBehaviour
{
    //1 enabled and -1 disabled
    private int SwitchStatus = 1;
    public GameObject switchButton;
    // Start is called before the first frame update
    void Start()
    {
        // ?????? ????? ????????? (??? ???? ?????? ????? ????? ??????? 1 ???)
        int soundSetting = PlayerPrefs.GetInt("sound", 1);
        // ????? ????? ?????????
        AudioListener.volume = soundSetting == 1 ? 1 : 0;
        // ????? ?????? ???? ????? ?? ???? ????? ?????????
        switchButton.transform.localPosition = new Vector3(soundSetting == 1 ? 212 : -212, switchButton.transform.localPosition.y, 0);

        // ????? SwitchStatus ?? ?? ?????? ????
        SwitchStatus = soundSetting == 1 ? 1 : -1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void switchButtonClick()
    {
        //switchButton.transform.localPosition = new Vector3 (-switchButton.transform.localPosition.x, switchButton.transform.localPosition.y, 0);
        switchButton.transform.DOLocalMoveX(-switchButton.transform.localPosition.x, 0.5f);
        SwitchStatus = (int)Mathf.Sign(-switchButton.transform.localPosition.x);
        Debug.Log("switch status : " + SwitchStatus);
        if (SwitchStatus == 1)
        {
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("sound", 1);
        }
        else if (SwitchStatus == -1)
        {
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("sound", 0);
        }
        PlayerPrefs.Save();
    }

}
