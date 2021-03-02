using System;
using UnityEngine;

namespace Obstacles
{
    public class ObstacleStatic : Obstacle
    {
        [SerializeField] private Sprite bittenIceCream;

        private SpriteRenderer _spriteRenderer;

        private void Start()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
        }

        private void Update()
        {
            if (health == 1 && gameObject.CompareTag("ObstacleStatic"))
            {
                _spriteRenderer.sprite = bittenIceCream;
            }
        }

        protected override void GETHit()
        {
            health--;
        }

        protected override void HandleDead()
        {
            Destroy(gameObject);
        }
    }
}