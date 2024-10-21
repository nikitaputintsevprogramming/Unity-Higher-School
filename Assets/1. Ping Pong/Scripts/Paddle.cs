using Assets._1._Ping_Pong.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [Header("Static Data")]
    public PaddleData paddledata;

    [Header("Customizable settings")]
    public float inputAxisName;

    private float yPosition;
    private MeshRenderer mesh;
    private AudioSource bounceSfx;

    private void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        bounceSfx = GetComponent<AudioSource>();
    }
}
