using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TapsellPlusSDK;
using TapsellPlusSDK.models;

public class TapsellAd : MonoBehaviour
{
    public int tapselladhelper;
    public string _responseId;
    // Start is called before the first frame update
    void Start()
    {
            TapsellPlus.Initialize("ihmigsicflbjhrfmcbfinfhnoridjrteklohonlfpqmhpmleajigscijcqmpgoikomsano",
            adNetworkName => Debug.Log(adNetworkName + " Initialized Successfully."),
            error => Debug.Log(error.ToString()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void helperadd()
    {
        tapselladhelper++;
    }
    public void request()
    {
        TapsellPlus.RequestRewardedVideoAd("681694588accde53baff035c",
           TapsellPlusAdModel =>
           {
               Debug.Log("on response" + TapsellPlusAdModel.responseId);
               _responseId = TapsellPlusAdModel.responseId;
           },
           error =>
           {
               Debug.Log("Error" + error.message);
           }
            );
    }
    public void show()
    {
        TapsellPlus.ShowRewardedVideoAd(_responseId,
            TapsellPlusAdModel =>
            {
                Debug.Log("OnOpenAd" + TapsellPlusAdModel.zoneId);
            },
            TapsellPlusAdModel =>
            {
                Debug.Log("onRewarded" + TapsellPlusAdModel.zoneId);
            },
            TapsellPlusAdModel =>
            {
                Debug.Log("onClosed" + TapsellPlusAdModel.zoneId);
            },
            error =>
            {
                Debug.Log("OnError" + error.errorMessage);
            }
            );
    }
}
