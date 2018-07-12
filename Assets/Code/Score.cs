using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public TextMesh ScoreLabel;
    public GameObject BallPref;
    public Transform PaddleObject;

    private GameObject ball;
    private int score;

	void Update ()
    {
	    ball = GameObject.FindGameObjectWithTag("Ball");
        ScoreLabel.text = score.ToString();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            score++;
            GetComponent<AudioSource>().Play();
            Destroy(ball);
            Instantiate(BallPref,
                new Vector3(PaddleObject.transform.position.x + 2, PaddleObject.transform.position.y, 0),
                Quaternion.identity).transform.parent = PaddleObject;
            
        }
    }
}
