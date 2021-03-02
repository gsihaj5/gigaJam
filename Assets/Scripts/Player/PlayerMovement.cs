using System;
using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private int player;
        [SerializeField] private float speed;
        [SerializeField] private float maxRange;
        [SerializeField] private GameObject paddle;


        private Rigidbody2D rb;
        private Transform _transform;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
            _transform = GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
            Move();
        }

        private void Move()
        {
            Vector2 newSpeed = new Vector2(
                Input.GetAxisRaw($"HorizontalPlayer{player}") * speed,
                Input.GetAxisRaw($"VerticalPlayer{player}") * speed
            );

            rb.velocity = newSpeed;

            Vector3 paddleLocalPos = paddle.transform.localPosition;
            Vector3 playerLocalPos = _transform.localPosition;

            Vector2 posRelativeToPaddle = new Vector2(
                playerLocalPos.x - paddleLocalPos.x,
                playerLocalPos.y - paddleLocalPos.y
            );

            print($"Player{player} " + (posRelativeToPaddle.x < -maxRange));

            if (posRelativeToPaddle.x < -maxRange)
                _transform.localPosition = new Vector2(paddleLocalPos.x - maxRange, playerLocalPos.y);
            if (posRelativeToPaddle.x > maxRange)
                _transform.localPosition = new Vector2(paddleLocalPos.x + maxRange, playerLocalPos.y);

            if (posRelativeToPaddle.y < -maxRange)
                _transform.localPosition = new Vector2(playerLocalPos.x, paddleLocalPos.y - maxRange);
            if (posRelativeToPaddle.y > maxRange)
                _transform.localPosition = new Vector2(playerLocalPos.x, paddleLocalPos.y + maxRange);
        }
    }
}