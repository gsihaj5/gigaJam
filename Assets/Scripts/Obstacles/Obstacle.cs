using System;
using UnityEngine;

namespace Obstacles
{
    public abstract class Obstacle : MonoBehaviour
    {
        [SerializeField] protected int health;
        [SerializeField] protected int point;

        public delegate void ObstacleDeadHandler(int point);

        public static event ObstacleDeadHandler ObstacleDead;

        protected void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Ball"))
                GETHit();

            if (health <= 0)
            {
                OnObstacleDead();
                HandleDead();
            }
        }

        protected abstract void GETHit();
        protected abstract void HandleDead();

        protected virtual void OnObstacleDead()
        {
            if (ObstacleDead != null)
                ObstacleDead(point);
        }
    }
}