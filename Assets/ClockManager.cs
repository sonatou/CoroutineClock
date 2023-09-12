using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockManager : MonoBehaviour
{
    public RectTransform hours, minutes, seconds;
    public Button startButton, stopButton;
    private Coroutine hoursCoroutine;
    private Coroutine minutesCoroutine;
    private Coroutine secondsCoroutine;

    private bool isRunning;

    void Start()
    {
        startButton.onClick.AddListener(IniciarContagem);
        stopButton.onClick.AddListener(PararContagem);
    }

    private void IniciarContagem()
    {
        if (!isRunning)
        {
            isRunning = true;
            hoursCoroutine = StartCoroutine(StartHours());
            minutesCoroutine = StartCoroutine(StartMinutes());
            secondsCoroutine = StartCoroutine(StartSeconds());
        }
    }
    private void PararContagem()
    {
        isRunning = false;
        StopCoroutine(hoursCoroutine);
        StopCoroutine(minutesCoroutine);
        StopCoroutine(secondsCoroutine);
    }

    IEnumerator StartHours()
    {
        while (true)
        {
            hours.Rotate(0f, 0f, -0.0086f);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator StartMinutes()
    {
        while (true)
        {
            minutes.Rotate(0f, 0f, -0.1033f);
            yield return new WaitForSeconds(1f);
        }
    }

    IEnumerator StartSeconds()
    {
        while (true)
        {
            seconds.Rotate(0f, 0f, -6f);
            yield return new WaitForSeconds(1f);
        }
    }
}

