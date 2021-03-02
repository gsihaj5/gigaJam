using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    private int _point;
    [SerializeField] private TextMeshProUGUI endScoreText;

    // Start is called before the first frame update
    void Start()
    {
        _point = GameObject.Find("PointManager").GetComponent<PointManager>().Point;
        endScoreText.text = $"{_point}";
    }

    // Update is called once per frame
    void Update()
    {
    }
}