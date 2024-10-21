using System.Collections;
using UnityEngine;

namespace Assets._1._Ping_Pong.Scripts
{
    [CreateAssetMenu(fileName = "PaddleData", menuName = "ScriptableObjects/SpawnManagerScriptableOnjects", order = 1)]
    public class PaddleData : ScriptableObject
    {
        public float MovementSpeedScaleFactor;
        public float MovementSpeedScale;
    }
}