using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;

    private Vector2 target, myPosition;
    private bool isMoving;
    
    private void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        myPosition = new Vector2(transform.position.x, transform.position.y);

        if (Input.GetMouseButtonDown(0)) { target = new Vector2(mousePos.x, transform.position.y);
            isMoving = true;
        }

        if (isMoving)
        {
            transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime * moveSpeed);

            if (myPosition == target) { isMoving = false; }
        }
    }

    public void SetIsMovingState(bool isMoving) { this.isMoving = isMoving; }
}
