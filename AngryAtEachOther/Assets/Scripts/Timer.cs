using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    float currentTime = 0f;
    public float startTime = 20f;
    [SerializeField] public Text countdownText;

    public int Next;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        //countdownText.color = Color;

        if (currentTime <= 0)
        {
            SceneManager.LoadScene(Next);
        }
    }
}
