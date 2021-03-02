namespace Obstacles
{
    public class ObstacleStatic : Obstacle
    {
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