using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public bool MoveLeft;
    public bool MoveRight;

    public float moveDir;

    void Update()
    {
        transform.position += new Vector3(moveDir, 0f, 0f);
        if (MoveLeft)
        {
            if(transform.position.x > -2.25f)
            {
                moveDir = -0.2f;
            }
            else
            {
                moveDir = 0f;
                transform.position = new Vector3(-2.25f, transform.position.y, transform.position.z);
            }
        }
        else if (MoveRight)
        {
            if (transform.position.x < 2.25f)
            {
                moveDir = 0.2f;
            }
            else
            {
                moveDir = 0f;
                transform.position = new Vector3(2.25f, transform.position.y, transform.position.z);
            }
        }
        else
        {
            moveDir = 0f;
        }
    }
    public void StopLeft()
    {
        MoveLeft = false;
    }
    public void moveLeft()
    {
        MoveLeft = true;
    }
    public void StopRight()
    {
        MoveRight = false;
    }
    public void moveRight()
    {
        MoveRight = true;
    }
}
