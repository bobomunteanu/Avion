using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
   void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "wall")
        {
            Debug.Log("touched wall");
            Debug.Break();
            Application.Quit();
        }
    }
}
