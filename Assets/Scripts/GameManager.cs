using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameObject _obstacles;
    private GameObject _balls;
    public bool IsWinning { get; private set; }
    [field: SerializeField] public int Level { get; set; }

    private void Start()
    {
        _obstacles = GameObject.Find("Obstacles");
        _balls = GameObject.Find("Balls");
        IsWinning = false;
    }

    void Update()
    {
        if (_obstacles == null)
        {
            IsWinning = false;
            _obstacles = GameObject.Find("Obstacles");
        }

        if (_balls == null)
            _balls = GameObject.Find("Balls");

        ConcludeEndGame();
    }

    private void ConcludeEndGame()
    {
        if (_obstacles && _obstacles.transform.childCount <= 0)
        {
            IsWinning = true;
            EndGame();
        }

        if (_balls && _balls.transform.childCount <= 0) EndGame();
    }

    private void EndGame()
    {
        print("game ended");
        Level++;
        SceneManager.LoadScene("EndGameScene");
    }
}