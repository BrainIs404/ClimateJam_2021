using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnClickFunction : MonoBehaviour
{
    public Transform target;
    public float moveSpeed;
    public Rigidbody2D rb;

    void OnMouseDown() {
        print("Clicked on Object!!!");
        Move();
    }
    
    void Move()
    {
        Vector2 position = transform.position;

        target.position = position;
    }

}