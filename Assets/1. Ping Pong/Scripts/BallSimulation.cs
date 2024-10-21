using UnityEditor;
using UnityEngine;

namespace Ball
{
    public class BallSimulation
    {
        private Vector2 velocity;

        public BallSimulation(Vector2 initialVelocity)
        {
            velocity = initialVelocity;
        }

        public Vector2 UpdatePosition(Vector2 currentPosition, float deltaTime)
        {
            return currentPosition + velocity * deltaTime;
        }

        public void Invert(Vector2 normal)
        {
            velocity = Vector2.Reflect(velocity, normal);
        }

        public Vector2 GetVelocity()
        {
            return velocity;
        }
    }
}