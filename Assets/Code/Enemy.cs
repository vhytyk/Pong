using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 1;
    private Vector3 targetPos;
    private GameObject ballObj;

    void Update ()
    {
        ballObj = GameObject.FindGameObjectWithTag("Ball");
        if (ballObj != null && ballObj.GetComponent<Rigidbody>().velocity.x > 0)
        {
            targetPos = Vector3.Lerp(gameObject.transform.position, ballObj.transform.position, Time.deltaTime * Random.Range(4, 8));
            gameObject.transform.position = new Vector3(22, targetPos.y, 0);
        }
    }
}
