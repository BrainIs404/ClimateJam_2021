using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickToMove : MonoBehaviour {
    [SerializeField]
    [Range(2, 12)]
    private float speed = 4f;
    private Vector3 targetPosition;

    private bool isMoving = false;
    
    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            SetTargetPosition();
        }

        if (isMoving) {
            Move();
        }
    }

    void SetTargetPosition()
    {
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition.z = transform.position.z;

        isMoving = true;
    }

    void Move() {
        transform.rotation = Quaternion.LookRotation(Vector3.forward, targetPosition);
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition) {
            isMoving = false;
        }
    }
}