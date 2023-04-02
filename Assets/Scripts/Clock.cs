using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField] private Transform hoursHand;
    [SerializeField] private Transform minutesHand;
    [SerializeField] private Transform secondsHand;
    [Space(10)]
    [SerializeField] private AudioSource audioSource;


    private int hour;
    private int minute;
    private int second;

    private int lastSecond;

   
    void Update()
    {
        hour = DateTime.Now.Hour;
        minute = DateTime.Now.Minute;
        second = DateTime.Now.Second;

        if (second != lastSecond)
        {
            audioSource?.Play();
            lastSecond = second;
        }


        Quaternion rotation = Quaternion.identity;

        rotation = Quaternion.AngleAxis(second * 6f, transform.right);
        secondsHand.rotation = rotation;

        rotation = Quaternion.AngleAxis(minute * 6f, transform.right);
        minutesHand.rotation = rotation;

        rotation = Quaternion.AngleAxis(hour * 30f, transform.right);
        hoursHand.rotation = rotation;
    }
}
