using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTimer : MonoBehaviour
{
    public int startSeconds = 10;     // Configurable starting time
    public GameObject cube;            // Assign your Cube in the Inspector

    private float timer = 0f;
    private float waitTime = 1f;
    private int timeLeft;
    private bool isRunning = true;

    void Start()
    {
        timeLeft = startSeconds;
        Debug.Log("Time left: " + timeLeft);
    }

    void Update()
    {
        if (!isRunning)
            return;

        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            timer -= waitTime;

            timeLeft--;

            if (cube != null)
            {
                cube.SetActive(!cube.activeSelf);
            }

            if (timeLeft > 0)
            {
                Debug.Log("Time left: " + timeLeft);
            }
            else
            {
                Debug.Log("TIMES UP");
                isRunning = false;
            }
        }
    }
}
