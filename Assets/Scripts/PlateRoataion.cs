using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlateRoataion : MonoBehaviour
{
    public static bool isGameStarted = false;
    public Transform PlateTrransform;
    public Transform SphereTransform;
    public GameObject GameOverMenu;
    public Text StopWatchText;
    float horizontalSpeed = 2.0f;
    float verticalSpeed = 2.0f;
    float startTime = 0;
    void Update()
    {
        if (isGameStarted)
        {
            StopWatch(true);
        }
        if (!(SphereTransform.position.y < -3f))
        {
            float h = horizontalSpeed * Input.GetAxis("Horizontal") * -1;
            float v = verticalSpeed * Input.GetAxis("Vertical");
            PlateTrransform.Rotate(v, 0, h);
        }
        else
        {
            isGameStarted = false;
            StopWatch(false);
            GameOverMenu.SetActive(true);
        }
    }
    public void StopWatch(bool IsWorking)
    {
        if (IsWorking)
        {
            startTime += Time.deltaTime;
            StopWatchText.text = startTime.ToString("F2");
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
}
