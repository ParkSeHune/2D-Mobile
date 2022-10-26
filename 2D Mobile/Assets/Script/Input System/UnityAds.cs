using System.Collections;
using System.Data.SqlTypes;
using UnityEngine;
using UnityEngine.Advertisements;
using static UnityEditor.Progress;

public class UnityAds : MonoBehaviour
{
    private string androidID = "4981639";
    private int gameMoney = 0;

    void Start()
    {
        Advertisement.Initialize(androidID);

        ShowBanner();
    }

    public void ShowInterstitial()
    {
        if (Advertisement.IsReady("Interstitial_Android"))
        {
            Advertisement.Show("Interstitial_Android");
        }
    }

    public void ShowBanner()
    {
        if (Advertisement.IsReady("Banner_Android"))
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);

            Advertisement.Banner.Show("Banner_Android");
        }
        else
        {
            StartCoroutine(RepeateBanner());
        }
    }

    private IEnumerator RepeateBanner()
    {
        yield return new WaitForSeconds(1f);
        ShowBanner();
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Failed:
                Debug.Log("Failed Ads");
                break;
            case ShowResult.Skipped:
                Debug.Log("Skipped Ads");
                break;
            case ShowResult.Finished:
                Debug.Log("Finised Ads");
                gameMoney += 1000;
                break;
            default:
                break;
        }
    }

    public void ShowRewarded()
    {
        if (Advertisement.IsReady())
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };

            Advertisement.Show("Rewarded_Android", options);
        }
    }
}
