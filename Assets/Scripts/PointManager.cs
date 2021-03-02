using System.Collections;
using System.Collections.Generic;
using Obstacles;
using TMPro;
using UnityEngine;

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

    private void OnObstacleDead(int point)
    {
        Point += point;
        scoreText.text = $"Points: {Point}";
    }
}