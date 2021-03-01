using UnityEngine;

namespace Player
{
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private int player;
        [SerializeField] private float speed;

        private Rigidbody2D rb;

        // Start is called before the first frame update
        void Start()
        {
            rb = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            Move();
        }

        private void Move()
        {
            rb.velocity = new Vector2(
                Input.GetAxisRaw($"HorizontalPlayer{player}") * speed,
                Input.GetAxisRaw($"VerticalPlayer{player}") * speed
            );
        }
    }
}