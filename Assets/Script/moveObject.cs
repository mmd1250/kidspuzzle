using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{

    //public float xSetPosition;
    //public float ySetPosition;

    public float xErrorPosition;
    public float yErrorPosition;

    public Vector3 setPosition;
    int touchLock;

    // Use this for initialization
    void Start()
    {
        touchLock = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetTouch(0).position);
        if (touchLock == 0 &&Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary && gameObject.transform.position.x> -Screen.width && gameObject.transform.position.x< Screen.width && gameObject.transform.position.y < Screen.height && gameObject.transform.position.y > -Screen.height)
        {
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            touchPosition.z = -1.5f;
            double halfScreen = Screen.width / 2.0;

            //Check if it is left or right?
           // if (touchPosition.x < halfScreen)
           // {
             //   gameObject.transform.Translate(touchPosition);
         //   }
          //  else if (touchPosition.x > halfScreen)
           // {
                gameObject.transform.position = touchPosition;
            // }

        }


        if(gameObject.transform.position.x < setPosition.x + xErrorPosition && gameObject.transform.position.x > setPosition.x - xErrorPosition && gameObject.transform.position.y < setPosition.y + yErrorPosition && gameObject.transform.position.y > setPosition.y + yErrorPosition)
        {
            gameObject.transform.position = setPosition;
            touchLock = 1;

        }

    }
}
