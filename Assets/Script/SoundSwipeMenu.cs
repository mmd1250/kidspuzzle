using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SoundSwipeMenu : MonoBehaviour
{
    //1 enabled and -1 disabled
    private int SwitchStatus = 1;
    public int MoveX;
    public GameObject switchButton;
    public GameObject BackGround;
    // Start is called before the first frame update
    void Start()
    {
        int soundSetting = PlayerPrefs.GetInt("sound", 1);
        AudioListener.volume = soundSetting == 1 ? 1 : 0;
        switchButton.transform.localPosition = new Vector3(soundSetting == 1 ? MoveX : -MoveX, switchButton.transform.localPosition.y, 0);
        SwitchStatus = soundSetting == 1 ? 1 : -1;
        if (SwitchStatus == -1)
        {
            BackGround.GetComponent<RawImage>().color = Color.red;
        }
        if (SwitchStatus == 1)
        { BackGround.GetComponent<RawImage>().color = Color.green;
        }

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
            BackGround.GetComponent<RawImage>().color = Color.green;
            AudioListener.volume = 1;
            PlayerPrefs.SetInt("sound", 1);
        }
        else if (SwitchStatus == -1)
        {
            BackGround.GetComponent<RawImage>().color = Color.red;
            AudioListener.volume = 0;
            PlayerPrefs.SetInt("sound", 0);
        }
        PlayerPrefs.Save();
    }

}
