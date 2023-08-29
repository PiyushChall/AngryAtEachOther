using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TowardsMouse : MonoBehaviour
{
    float minSpeed = 0.3f;
    float maxSpeed = 2f;
    float moveSpeed;

    float secondsToMaxDifficulty = 40f;

    private int gameOverScene = 16;
    private int went2FarScene = 17;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveSpeed = Mathf.Lerp(minSpeed, maxSpeed, GetDifficultyPercent());
        Vector2 cursurPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, cursurPos, moveSpeed * Time.deltaTime);
    }
    float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Obj")
        {

            SceneManager.LoadScene(gameOverScene);
        }
        else if (collision.tag == "Bounds")
        {
            SceneManager.LoadScene(went2FarScene);
        }
    }
}
