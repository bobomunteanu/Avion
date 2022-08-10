using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCollision : MonoBehaviour
{
    private UIManager _uiManager;

    void Start()
    {
        _uiManager = GameObject.Find("Score").GetComponent<UIManager>();
        if (_uiManager == null)
        {
            Debug.Log("Null ui manager");
        }
    }

    void OnCollisionEnter(Collision col)
   {
        if (col.gameObject.tag == "wall")
        {
            _uiManager.gameOver();
            Debug.Break();
            Application.Quit();
        }
    }
}
