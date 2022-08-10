using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float transitionSpeedHorizontal;
    public float transitionSpeedVertical;
    public Rigidbody Player;

    void Start()
    {
        Player = GetComponent<Rigidbody>();
    }

    void Update()
{
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                Player.AddForce(Vector3.left * transitionSpeedHorizontal, ForceMode.VelocityChange);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                Player.AddForce(Vector3.right * transitionSpeedHorizontal, ForceMode.VelocityChange);            
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                Player.AddForce(Vector3.up * transitionSpeedVertical, ForceMode.VelocityChange);  
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                Player.AddForce(Vector3.down * transitionSpeedVertical, ForceMode.VelocityChange);
            }
    }
}
