using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public Vector2 spin;
    //public float spinSpeed = 2f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
            if (Input.GetAxis("Mouse X") > 0 || Input.GetAxis("Mouse X") < 0)
            {
                
                spin.x += Input.GetAxis("Mouse X");
                transform.localRotation = Quaternion.Euler(0f, -spin.x, 0f);
                Debug.Log("column spinning!");

            }
            else
            {
                Debug.Log("column stopped!!");
            }

    }

}
