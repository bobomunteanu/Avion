using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] public static int score;
    [SerializeField] private TMP_Text _scoreText;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        _scoreText.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

    }

    public void updateScore()
    {
        score += 10;
        _scoreText.text = "Score: " + score.ToString();
    }

    public void gameOver()
    {
        _scoreText.text = "Game Over!";
    }
}
