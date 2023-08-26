using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Static : MonoBehaviour
{
    public int gameOverScene;
    public int went2FarScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
