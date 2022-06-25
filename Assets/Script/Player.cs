using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ePlayer
{
    PlayerOne,
    PlayerTwo,
    PlayerThree,
    PlayerFour
}

public class Player : MonoBehaviour
{
  
    public float speed = 15f;
    public ePlayer player;


    void FixedUpdate()
    {
        float inputSpeed = 0;
        float inputSpeedB = 0;
        float inputSpeedC = 0;
        if (player == ePlayer.PlayerOne)
        {
            inputSpeed = Input.GetAxisRaw("Player1");
        }
        else if (player == ePlayer.PlayerTwo)
        {
            inputSpeedC = Input.GetAxisRaw("Player2");
        }
        else if (player == ePlayer.PlayerThree)
        {
            inputSpeedB = Input.GetAxisRaw("Player3");
        }
        else if (player == ePlayer.PlayerFour)
        {
            inputSpeedB = Input.GetAxisRaw("Player4");
        }

        transform.position += new Vector3(inputSpeed, 0f, 0f * speed * Time.deltaTime);
        transform.position += new Vector3(0f, 0f, inputSpeedB * speed * Time.deltaTime);
        transform.position += new Vector3(inputSpeedC, 0f, 0f * -speed * Time.deltaTime);
    }
}

