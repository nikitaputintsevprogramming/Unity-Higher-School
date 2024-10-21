using System;
using System.Collections;
using UnityEngine;

namespace Ball
{
    public class BallLogic
    {
        public delegate void OnDestroy();
        public OnDestroy e_OnDestroyed;

        private BallSimulation ballSimulation;

        public BallLogic(BallSimulation simulation)
        {
            ballSimulation = simulation;
        }   

        public bool Hit (string tag)
        {
            Debug.Log($"Hit detected with tag: {tag}");

            switch (tag)
            {
                case "HorizontalWall":
                    ballSimulation.Invert(Vector2.up);
                    return true;

                case "VerticalWall":
                    //ballSimulation.Invert(Vector2.right);
                    e_OnDestroyed();
                    return true;

                case "Paddle":
                    ballSimulation.Invert(Vector2.right);
                    return true;

                default:
                    return true;
            }
        }


    }
}