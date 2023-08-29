using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomMovements : MonoBehaviour
{
    private float minX = 7.5f;
    private float maxX = -7.5f;
    private float minY = -4f;
    private float maxY = 4f;

    private float minSpeed = 0.5f;
    private float maxSpeed = 2.5f;
    private float moveSpeed;

    private Vector2 targetPosition;

    private int gameOverScene = 16;
    private int went2FarScene = 17;

    private float secondsToMaxDifficulty = 30f;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = GetRandomPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Vector2)transform.position != targetPosition)
        {
            moveSpeed = Mathf.Lerp( minSpeed, maxSpeed, GetDifficultyPercent());
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, moveSpeed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
    }

    private Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
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
    float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secondsToMaxDifficulty);
    }
}
