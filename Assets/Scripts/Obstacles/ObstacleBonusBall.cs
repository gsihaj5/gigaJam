using System;
using UnityEngine;

namespace Obstacles
{
    public class ObstacleBonusBall : Obstacle
    {
        [SerializeField] private GameObject ballPrefab;
        private GameObject _balls;

        private void Start()
        {
            _balls = GameObject.Find("Balls");
        }

        protected override void GETHit()
        {
            health--;
        }

        protected override void HandleDead()
        {
            GameObject newBalls = Instantiate(ballPrefab, gameObject.transform);

            newBalls.transform.parent = _balls.transform;
            Destroy(gameObject);
        }
    }
}