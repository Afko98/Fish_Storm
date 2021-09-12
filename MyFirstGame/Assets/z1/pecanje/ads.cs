using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class ads : MonoBehaviour, IUnityAdsListener
{
    public GameObject text;
#if UNITY_IOS
    string gameId = "4301674";
#else
    string gameId = "4301675";
    #endif

    void Start()
    {
        Advertisement.Initialize(gameId);
        Advertisement.AddListener(this);
    }

    // Update is called once per frame
    public void PlayAd()
    {
        if (Advertisement.IsReady("video"))
        {
            Advertisement.Show("video");
        }
        else{
            text.GetComponent<Text>().text= ":(";
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
     
    }

    public void OnUnityAdsDidError(string message)
    {
      
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        Debug.Log("ad start");
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        if(placementId=="video" && showResult == ShowResult.Finished)
        {
            localMoney.localCoins = localMoney.localCoins*2;
            uslovi.giftsInGame = uslovi.giftsInGame*2;
            uslovi.brReklama++;
            if (uslovi.brReklama > 4)
                achivments.watch5 = true;
            if (uslovi.brReklama > 9)
                achivments.watch10 = true;
            if (uslovi.brReklama > 19)
                achivments.watch20 = true;
        }
    }
}
