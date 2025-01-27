using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiTouchDisplay : MonoBehaviour
{
    public Text multiTouchInfoDisplay;
    private Touch theTouch;
    private int maxTapCount = 0;
    private string multiTouchInfo;

    void Update()
    {
        multiTouchInfo = string.Format("Max tap count: {0}\n", maxTapCount);

        if(Input.touchCount > 0 )
        {
            for (int i = 0; i < Input.touchCount; i++)
            {
                theTouch = Input.GetTouch(i);

                multiTouchInfo += 
                    string.Format("Touch: {0} - Position: {1} - Tap count: {2} - Finger ID: {3} \nRadius {4} ({5}%)\n", 
                    i, theTouch.position, theTouch.tapCount, theTouch.fingerId, theTouch.radius, 
                    ((theTouch.radius/(theTouch.radius + theTouch.radiusVariance)) * 100 ).ToString());
            }

            if(theTouch.tapCount > maxTapCount)
            {
                maxTapCount = theTouch.tapCount;
            }
            
        }

        multiTouchInfoDisplay.text = multiTouchInfo;
    }
}
