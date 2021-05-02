using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public PathFollower path;
    public GameObject player;

    public Node start;
    public Node end;
    Vector2 nodePosition = new Vector2();
    void Start() {
        if (this.name == "Start") {
            nodePosition = end.transform.position;
        }

        if (this.name == "End") {
            nodePosition = start.transform.position;
        }
    }

    // Start is called before the first frame update
    void OnMouseDown() {
        Vector2 playerPosition = player.transform.position;
        
        if (playerPosition.x >= (nodePosition.x - 5) && playerPosition.x <= (nodePosition.x + 5))
        {
            if (playerPosition.y >= (nodePosition.y - 5) && playerPosition.y <= (nodePosition.y + 5))
            {
                path.canMove(4f);
            }
        }
        
    }
}
