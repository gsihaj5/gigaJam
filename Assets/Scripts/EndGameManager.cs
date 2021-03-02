using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    private int _point;
    private int _nextLevel;
    private bool _isWinning;
    private GameManager _gameManager;
    [SerializeField] private GameObject nextLevelButton;
    [SerializeField] private TextMeshProUGUI endScoreText;

    // Start is called before the first frame update
    void Start()
    {
        _point = GameObject.Find("PointManager").GetComponent<PointManager>().Point;
        endScoreText.text = $"{_point}";
        _gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        _nextLevel = _gameManager.Level;
        _isWinning = _gameManager.IsWinning;

        if (!_isWinning)
            nextLevelButton.SetActive(false);
    }

    public void GoToNextLevel()
    {
        SceneManager.LoadScene($"Level{_nextLevel}");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void RetryLevel()
    {
        _nextLevel--;
        _gameManager.Level = _nextLevel;
        SceneManager.LoadScene($"Level{_nextLevel}");
    }
}