using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject _obstacles;
    private GameObject _balls;

    private void Start()
    {
        _obstacles = GameObject.Find("Obstacles");
        _balls = GameObject.Find("Balls");
    }

    void Update()
    {
        if (_obstacles != null && _obstacles.transform.childCount <= 0) EndGame();
        if (_balls != null && _balls.transform.childCount <= 0) EndGame();
    }

    private void EndGame()
    {
        print("game ended");
        SceneManager.LoadScene("EndGameScene");
    }
}