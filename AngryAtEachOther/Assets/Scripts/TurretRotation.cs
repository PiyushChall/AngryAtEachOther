using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TurretRotation : MonoBehaviour
{
    public Transform targetObject;

    public Transform turret;

    public float rotationModifier;

    public float speed;

    public GameObject projectile;

    private float timebetweenfire;
    public float resetTime = 4f;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timebetweenfire <= 0)
        {
            Instantiate(projectile, turret.position, turret.rotation);
            timebetweenfire = resetTime;
        }
        else
        {
            timebetweenfire -= Time.deltaTime;
        }


    }
    private void FixedUpdate()
    {
        Vector3 targetRotation = targetObject.transform.position - transform.position;
        float angles = Mathf.Atan2(targetRotation.y, targetRotation.x) * Mathf.Rad2Deg - rotationModifier;
        Quaternion q = Quaternion.AngleAxis(angles, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, speed * Time.deltaTime);
        
    }
    



}
