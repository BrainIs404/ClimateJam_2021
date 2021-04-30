using UnityEngine;
using System.Collections;

public class PathFollower : MonoBehaviour {
    Node[] PathNode;

    public GameObject Player;
    public float MoveSpeed;
    float Timer;

    int CurrentNode = 0;
    Vector2 startPosition;

    public bool isMove = false;
    static Vector3 CurrentPositionHolder;
    void Start() {
        PathNode = GetComponentsInChildren<Node>();
        
        Debug.Log(PathNode);
        CheckNode();
    }

    void CheckNode() {
        Timer = 0;
        startPosition = Player.transform.position;
        CurrentPositionHolder = PathNode[CurrentNode].transform.position;
    }

    void Update() {
        if (isMove) {
            /*
            if (Input.GetMouseButtonDown(0)) {
                isMove = !isMove;
            }*/

            Timer += Time.deltaTime * MoveSpeed;

            if (Player.transform.position != CurrentPositionHolder) {
                Player.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder, Timer);
            } else {
                if (CurrentNode < PathNode.Length - 1) {
                    CurrentNode++;
                    CheckNode();
                } else {
                    System.Array.Reverse(PathNode);
                    CurrentNode = 0;
                    isMove = false;
                }
            }
        }
    }

    public void canMove()
    {
        isMove = true;
    }
}