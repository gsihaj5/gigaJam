using UnityEngine;

namespace Obstacles
{
    public class ObstacleBonusBall : Obstacle
    {
        [SerializeField] private GameObject ballPrefab;

        protected override void GETHit()
        {
            health--;
        }

        protected override void HandleDead()
        {
            Instantiate(ballPrefab);
            Destroy(gameObject);
        }
    }
}