using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float transitionSpeedHorizontal;
    public float transitionSpeedVertical;
    void Update()
{
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.left * transitionSpeedHorizontal, ForceMode.VelocityChange);            
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody>().AddForce(Vector3.right * transitionSpeedHorizontal, ForceMode.VelocityChange);            
            }

            if (Input.GetKey(KeyCode.UpArrow))
            {               
                GetComponent<Rigidbody>().AddForce(Vector3.up * transitionSpeedVertical, ForceMode.VelocityChange);  
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {               
                GetComponent<Rigidbody>().AddForce(Vector3.down * transitionSpeedVertical, ForceMode.VelocityChange);
            }
    }
}
