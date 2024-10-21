using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;


namespace Ball
{
    public class Ball : MonoBehaviour, ILocalPositionAdapter
    {
        [Header("Customizable per instance")]
        [FormerlySerializedAs("Velocity")]
        public Vector3 InitialVelocity;

        private BallLogic ballLogic;
        private BallSimulation ballSimulation;

        public Vector3 LocalPosition
        {
            get { return transform.localPosition;  }
            set { transform.localPosition = value; }
        }

        private void Awake()
        {
            ballSimulation = new BallSimulation(InitialVelocity);
            ballLogic = new BallLogic(ballSimulation);

            ballLogic.e_OnDestroyed += () => Destroy(gameObject);
        }

        private void FixedUpdate()
        {
            //transform.localPosition = transform.localPosition + velocity * Time.fixedDeltaTime;
            transform.localPosition = ballSimulation.UpdatePosition(transform.localPosition, Time.fixedDeltaTime);
            Debug.Log(ballSimulation.GetVelocity());
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            Debug.Log("Есть столкновение");
            ballLogic.Hit(other.gameObject.tag);
            //bool isAlive = ballLogic.Hit(other.gameObject.tag);
            //if (!isAlive)
            //{
            //    Destroy(gameObject);
            //}

            //if (other.gameObject.tag == "HorizontalWall")
            //{
            //    velocity = new Vector3(velocity.x, -velocity.y, velocity.z);
            //}
            //if (other.gameObject.tag == "VerticalWall")
            //{
            //    Destroy(gameObject);
            //}
            //if (other.gameObject.tag == "Paddle")
            //{
            //    velocity = new Vector3(-velocity.x, velocity.y, velocity.z);
            //}
        }
    }
}

