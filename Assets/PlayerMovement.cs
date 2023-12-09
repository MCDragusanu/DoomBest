using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.RightArrow)) {
            GetComponent<Rigidbody>().velocity = new Vector3(1 , 0 , 0);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(-1, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 1 , 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, -1, 0);
        }
    }
}
