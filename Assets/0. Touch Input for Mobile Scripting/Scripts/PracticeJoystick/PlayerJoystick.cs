using System.Collections;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    [SerializeField] float speed;

    void Update()
    {
        Vector3 finalSpeed = Joystick.Position * speed * Time.deltaTime;
        transform.Translate(finalSpeed);
        Debug.LogFormat("Текущая позиция джойстика: {0}, полученная скорость: {1}", Joystick.Position, finalSpeed);
    }
}
