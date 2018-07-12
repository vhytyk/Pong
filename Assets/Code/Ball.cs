using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float BallVelocity = 1000;
    private Rigidbody rb;
    private bool IsPlay;

    void Awake()
    {
        rb = gameObject.gameObject.GetComponent<Rigidbody>();
    }
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Return) && IsPlay == false)
        {
            transform.parent = null;
            IsPlay = true;
            rb.isKinematic = false;
            rb.AddForce(new Vector3(Random.Range(1, 3) == 1 ? BallVelocity : -BallVelocity,
                Random.Range(1, 3) == 1 ? BallVelocity : -BallVelocity,
                0));

        }

    }
}
