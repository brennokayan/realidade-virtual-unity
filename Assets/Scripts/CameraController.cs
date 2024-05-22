using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(Vector3.forward*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(Vector3.left*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(Vector3.back*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(Vector3.right*speed*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift)){

            if(Input.GetKey(KeyCode.LeftArrow)){
                transform.Rotate(Vector3.down * rotationSpeed * Time.deltaTime);
            }

            if(Input.GetKey(KeyCode.RightArrow)){
                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
            }

            // if(Input.GetKey(KeyCode.UpArrow)){
            //     transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime);
            // }

            // if(Input.GetKey(KeyCode.DownArrow)){
            //     transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime);
            // }

        }
          if (Input.GetKey(KeyCode.C)){
            transform.Translate(Vector3.right*(speed*3)*Time.deltaTime);
        }
    }
}
