using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject ball;
    public Vector3 startPos;


   
    void Start()
    {
        startPos = ball.transform.position;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click or Clique?");
            ball.transform.position = startPos;
        }
    }
}
