using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public PathFollower path;

    // Start is called before the first frame update
    void OnMouseDown() {
        path.canMove();
        
    }
}
