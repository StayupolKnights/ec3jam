﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationManager : MonoBehaviour
{
    public Text tray;
    Queue<string> notifications = new Queue<string>();
    public int maxDisplayedNotifications = 20;

    public void AddNotification(string message)
    {
        if (notifications.Count < maxDisplayedNotifications)
        {
            notifications.Enqueue(message);
        }
        else
        {
            notifications.Enqueue(message);
            notifications.Dequeue();
        }

        tray.text = "";

        foreach (string notify in notifications)
        {
            tray.text += "\n" + notify;
        }
    }
}
