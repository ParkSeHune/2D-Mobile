using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleAndroidNotifications;
using System;
using System.Text;

public class Notification : MonoBehaviour
{
    private string title = "알림";
    private string content = "엡에 접속하여 게임을 시작해 주세요"; 

    void Start()
    {
        OnApplicationPause(true);
    }

    private void OnApplicationPause(bool pause)
    {
#if UNITY_ANDROID
        NotificationManager.CancelAll(); //알림 제거

        if (pause)
        {
            DateTime timeNotify = DateTime.Now.AddMinutes(1); // 앱 종료 후 일정 시간 후에 알림이 가도록 설정

            TimeSpan time = timeNotify - DateTime.Now;

            NotificationManager.SendWithAppIcon(time, title, content, Color.blue, NotificationIcon.Star);

            DateTime specifiedTime = Convert.ToDateTime("20:00:00 PM");

            TimeSpan tempTime = specifiedTime - DateTime.Now;

            if (tempTime.Ticks > 0)
            {
                NotificationManager.SendWithAppIcon(time, title, content, Color.red, NotificationIcon.Clock);
            }
        }
#endif
    }
}
