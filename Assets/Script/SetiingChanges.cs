using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetiingChanges : MonoBehaviour
{
    public Button StartBtn;
    public GameObject Panel;
    public Button SettingBtn;
    public AudioSource AudioSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Setting_Panel_situation()
    { 
        SettingBtn.interactable = false;
        Panel.SetActive(true);
        AudioSource.Play();
        StartBtn.interactable=false;
        StartBtn.animator.enabled=false;
        //Time.timeScale = 0f;
    }
    public void resumeSelected()
    {
        SettingBtn.interactable = true;
        Panel.gameObject.SetActive(false);
        StartBtn.interactable=true;
        StartBtn.animator.enabled=true;
        AudioSource.Play();
    }
    }
