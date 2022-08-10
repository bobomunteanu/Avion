using System.Collections;
using System.Collections.Generic;
using Random = System.Random;
using System.Threading.Tasks;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject plm;
    public static bool needToGenerate;
    private int obstacleCount = 0;
    public static float boundary = 13f;
    private int blocksCreated = 0;
    public static float generateNewAt = 5f;
    private int total = 0;
    private int index = 1;
    private UIManager _uiManager;
    Random rnd = new System.Random();
    List<float> locations = new List<float>();

    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GameObject.Find("Score").GetComponent<UIManager>();
        if (_uiManager == null)
        {
            Debug.Log("Null ui manager");
        }

        completeList();
        generate();
    }

    public void generate()
    {
        int number;

        for (int i = 0; i <= obstacleCount; i++)
        {
            number = rnd.Next(0, locations.Count);
            Instantiate(plm, new Vector3((float)locations[number], (float)rnd.NextDouble() * 0.3f + 0.6f + 1.6f * i, 13), Quaternion.Euler(new Vector3(-90, 0, 0)));
            locations.RemoveAt(number);
        }
        blocksCreated++;
        completeList();

        if (total % 4 == 0 && total > 0)
        {
            obstacleCount++;
            generateNewAt -= 0.2f;
        }

        if(total / 4 == 4 * index)
        {
            BlockMovement.speed -= 3f;
            obstacleCount = 0;
            index++;
        }

    }

    private void completeList()
    {
        locations.Clear();

        locations.Add(-2.25f);
        locations.Add(-0.125f);
        locations.Add(0f);
        locations.Add(0.125f);
        locations.Add(2.25f);
    }

    // Update is called once per frame
    void Update()
    {
        if (needToGenerate)
        {
            if(_uiManager != null)
            {
                _uiManager.updateScore();
            }
            generate();
            total += blocksCreated;
            needToGenerate = false;
            blocksCreated = 0;
        }

        
    }

    void FixedUpdate()
    {
        
    }
}
