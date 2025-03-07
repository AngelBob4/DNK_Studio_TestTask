using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    private float _moveSpeed = 10;

    private void Update()
    {
        MovePipe();
    }

    public void SetSpeed(int speed)
    {
        _moveSpeed = speed;
    }

    private void MovePipe() 
    {
        transform.position = transform.position + (Vector3.left * _moveSpeed) * Time.deltaTime;

        if (transform.position.x < -32)
        {
            Destroy(gameObject);
        }
    }
}