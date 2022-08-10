using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMovement : MonoBehaviour
{
    private Rigidbody rigidbodyComponent;
    private bool passedBoundary = false;
    public static float speed = -3f;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodyComponent = GetComponent<Rigidbody>();
        rigidbodyComponent.velocity = new Vector3(0, 0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (this.transform.position.z < Obstacle.generateNewAt && !passedBoundary)
        {
            Obstacle.needToGenerate = true;
            passedBoundary = true;
            Obstacle.boundary += 0.1f;
        }

        if (this.transform.position.z < -3.8)
        {
            DestroyImmediate(this.gameObject, true);
        }

        
    }

}
