using System;
using System.Collections;
using System.Collections.Generic;
using Obstacles;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PointManager : MonoBehaviour
{
    public int Point { get; private set; }

    [SerializeField] private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        Point = 0;
        Obstacle.ObstacleDead += OnObstacleDead;
    }

    private void Update()
    {
        if (scoreText == null && SceneManager.GetActiveScene().name != "EndGameScene")
        {
            scoreText = GameObject.Find("Points").GetComponent<TextMeshProUGUI>();
            Point = 0;
        }
    }


    private void OnObstacleDead(int point)
    {
        Point += point;
        scoreText.text = $"Points: {Point}";
    }
}