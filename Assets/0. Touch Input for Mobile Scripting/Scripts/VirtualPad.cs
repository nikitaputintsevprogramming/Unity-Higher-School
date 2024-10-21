using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VirtualPad : MonoBehaviour
{
    public Text directionText;
    private Touch theTouch;
    private Vector2 touchStartPosition, touchEndPosition;
    private string direction;

    void Update()
    {
        if(Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);

            if(theTouch.phase == TouchPhase.Began )
            {
                touchStartPosition = theTouch.position;
            }
            else if (theTouch.phase == TouchPhase.Began || theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended )
            {
                touchEndPosition = theTouch.position;

                float x = touchEndPosition.x - touchStartPosition.x;
                float y = touchEndPosition.y - touchStartPosition.y;

                if(Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0 )
                {
                    direction = "tapped";
                }

                else if(Mathf.Abs(x) > Mathf.Abs(y))
                {
                    direction = x > 0 ? "right" : "left";
                }

                else
                {
                    direction = y > 0 ? "up" : "down";
                }
            }

            directionText.text = direction;
        }
    }
}
