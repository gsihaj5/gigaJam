using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private GameObject player1;

    [SerializeField] private GameObject player2;

    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        print("local " + _transform.localPosition);
        print("global " + _transform.position);
        HandlePosition();
        HandleRotation();
        HandleWidth();
    }

    private void HandlePosition()
    {
        Vector3 player1Pos = player1.transform.localPosition;
        Vector3 player2Pos = player2.transform.localPosition;

        float xPos = (player1Pos.x + player2Pos.x) / 2;
        float yPos = (player1Pos.y + player2Pos.y) / 2;
        _transform.localPosition = new Vector3(xPos, yPos, 0);
    }

    private void HandleRotation()
    {
        Vector3 player1Pos = player1.transform.localPosition;
        Vector3 player2Pos = player2.transform.localPosition;

        double angle = Math.Atan((player2Pos.x - player1Pos.x) / (player1Pos.y - player2Pos.y)) * (180 / Math.PI);

        _transform.eulerAngles = new Vector3(0, 0, (float) angle - 90);
    }

    private void HandleWidth()
    {
        Vector3 player1Pos = player1.transform.localPosition;
        Vector3 player2Pos = player2.transform.localPosition;

        float xDif = player1Pos.x - player2Pos.x;
        float yDif = player1Pos.y - player2Pos.y;

        double width = Math.Sqrt(xDif * xDif + yDif * yDif) * 100;

        _transform.transform.localScale = new Vector3((float) width, 20, 0);
    }
}