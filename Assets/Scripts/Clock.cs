using System;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [SerializeField]
    Transform hoursPivot, minutesPivot, secondsPivot;
    const float oneStepHourRotation = -30f;
    const float oneStepMinuteRotation = -6f;
    const float oneStepSecondRotation = -6f;

    void Update() {
        TimeSpan time = DateTime.Now.TimeOfDay;
        Debug.Log(oneStepSecondRotation * (float)time.TotalSeconds);
        hoursPivot.localRotation = Quaternion.Euler(0,0,oneStepHourRotation * (float)time.TotalHours);
        minutesPivot.localRotation = Quaternion.Euler(0,0,oneStepMinuteRotation * (float)time.TotalMinutes);
        secondsPivot.localRotation = Quaternion.Euler(0,0,oneStepSecondRotation * (float)time.TotalSeconds);
    }
}
