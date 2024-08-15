using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 direction;
    public float forwardSpeed;
    private int separateLane=1;
    public float laneDistance = 2.5f;
    private Vector3 position;
    public float jumpForce;
    // Start is called before the first frame update
    void Start()
    {
       controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (!GameController.isGameStarted)
        {
            return;
        }
        direction.z = forwardSpeed;
        if (SwipeManager.swipeRight)
        {
            separateLane++;
            if(separateLane == 3) { separateLane = 2; }
        }
        if (SwipeManager.swipeLeft)
        {
            separateLane--;
            if (separateLane == -1) { separateLane = 0; }
        }
        Vector3 targetPosition = transform.position.z * transform.forward + transform.position.y * transform.up;
        if (separateLane == 0)
        {
            targetPosition += Vector3.left * laneDistance;
        }else if (separateLane == 2)
        {
            targetPosition += Vector3.right * laneDistance;
        }
        if (transform.position != targetPosition)
        {
            Vector3 diff = targetPosition - transform.position;
            Vector3 moveDir = diff.normalized * 30 * Time.deltaTime;
            if (moveDir.sqrMagnitude < diff.magnitude)
                controller.Move(moveDir);
            else
                controller.Move(diff);
        };
        controller.Move(direction * Time.deltaTime);
    }
  
}
