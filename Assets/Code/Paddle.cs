using System;
using UnityEngine;

namespace Assets.Code
{
    public class Paddle : MonoBehaviour 
    {
        public float PaddleSpeed = 1;
        public Vector3 PlayerPos;

        void Update ()
        {
            float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical") * PaddleSpeed);
            PlayerPos = new Vector3(-22, Mathf.Clamp(yPos, -11.81f, 11.81f), 0);
            gameObject.transform.position = PlayerPos;
        }
    }
}
