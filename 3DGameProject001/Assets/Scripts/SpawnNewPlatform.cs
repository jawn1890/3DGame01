using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnNewPlatform : MonoBehaviour
{
    
    public GameObject newPlatform;

    public Vector3 startPos;
    public Vector3 newPos;
    public float xPos;
    public float yPos;
    public float zPos;
    // Start is called before the first frame update
    void Start()
    {
        yPos = transform.position.y;
        startPos = new Vector3(transform.position.x, yPos, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        yPos++;
        newPos = new Vector3(transform.position.x, yPos, transform.position.z);
        Debug.Log(newPos);
        Instantiate(newPlatform, newPos, Quaternion.identity);

    }
    
}
