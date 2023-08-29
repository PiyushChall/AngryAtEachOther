using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveTowards : MonoBehaviour
{
    public Transform otherplanets;

    float minSpeed = 0.3f;
    float maxSpeed = 2f;
    float moveSpeed;

    public float speed;
    public float rotationModifier;

    float secondsToMaxDifficulty = 30f;

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
        transform.position = Vector2.MoveTowards(transform.position, otherplanets.position, moveSpeed * Time.deltaTime);
        
    }
    private void FixedUpdate()
    {
        Vector3 targetRotation = otherplanets.transform.position - transform.position;
        float angles = Mathf.Atan2(targetRotation.y, targetRotation.x) * Mathf.Rad2Deg - rotationModifier;
        Quaternion q = Quaternion.AngleAxis(angles, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, speed * Time.deltaTime);
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
