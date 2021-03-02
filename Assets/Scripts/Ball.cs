using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D;

    public static void CreateBall()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();

        _rigidbody2D.AddForce(Vector2.down * 500);
    }

    // Update is called once per frame
    void Update()
    {
    }
}