using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoverObjeto : MonoBehaviour
{
    // Start is called before the first frame update
    float x = 1.5f;
    float y = 1.5f ;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        var horizontalInput=Input.GetAxis("Horizontal");
        var verticalInput=Input.GetAxis("Vertical");



        GetComponent<Rigidbody>().AddForce(
            new Vector3(horizontalInput * x, verticalInput * y,0)
        );
    }
}


// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class MoverObjeto : MonoBehaviour{
//     public x;
//     public y;
//     // Start is called before the first frame update
//     void Start()
//     {
        
//     }

//     // Update is called once per frame
//     void Update(){
//         var horizontalInput=Input.GetAxis("Horizontal");
//         var verticalInput=Input.GetAxis("Horizontal");



//         GetComponent<Rigidbody>().AddForce(
//             new Vector3(orizontalInput * x, verticalInput * y,0);
//         )
//     }
// }
