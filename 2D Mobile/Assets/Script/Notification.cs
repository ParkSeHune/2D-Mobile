using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleAndroidNotifications;
using System;
using System.Text;

public class Notification : MonoBehaviour
{
    private string title = "�˸�";
    private string content = "���� �����Ͽ� ������ ������ �ּ���"; 

    void Start()
    {
        OnApplicationPause(true);
    }

    private void OnApplicationPause(bool pause)
    {
#if UNITY_ANDROID
        NotificationManager.CancelAll(); //�˸� ����

        if (pause)
        {
            DateTime timeNotify = DateTime.Now.AddMinutes(1); // �� ���� �� ���� �ð� �Ŀ� �˸��� ������ ����

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
