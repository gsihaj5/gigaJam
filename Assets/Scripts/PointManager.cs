using System.Collections;
using System.Collections.Generic;
using Obstacles;
using TMPro;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    private int _point;

    [SerializeField] private TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        _point = 0;
        Obstacle.ObstacleDead += OnObstacleDead;
    }

    private void OnObstacleDead(int point)
    {
        _point += point;
        scoreText.text = $"Points: {_point}";
    }
}