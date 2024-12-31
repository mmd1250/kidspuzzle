using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part5 : MonoBehaviour
{
    [SerializeField]
    private Transform shadowPlace;
    private Vector2 initialPosition;
    private float deltaX, deltaY;
    public static bool locked5;
    public static bool touchLockPart5;
    private Vector2 boxColliderInit;
    private int sortingLayerHelper;
    public static bool colliderHelper;
    private int colliderHelperCheck;

    public bool touchHelper;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        touchLockPart5 = false;
        boxColliderInit = GetComponent<BoxCollider2D>().size;
        sortingLayerHelper = GetComponent<SpriteRenderer>().sortingOrder;
        colliderHelper = true;
        colliderHelperCheck = 0;

        touchHelper = false;


    }


    // Update is called once per frame
    void Update()
    {

        if (!colliderHelper)
        {
            colliderDisable();

        }

        if (colliderHelper && colliderHelperCheck == 1)
        {
            colliderEnable();
        }

        if (Input.touchCount > 0 && !locked5 && !touchLockPart5)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);


            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        touchHelper = true;

                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                        GameController5tike.lockPart5();
                        GetComponent<BoxCollider2D>().size = new Vector2(40f, 40f);

                    }
                    break;

                case TouchPhase.Moved:

                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
                    {
                        GetComponent<SpriteRenderer>().sortingOrder = 10;
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);


                    }
                    break;

                case TouchPhase.Ended:
                    GameController4tike.unlockParts();
                    GetComponent<BoxCollider2D>().size = boxColliderInit;
                    GetComponent<SpriteRenderer>().sortingOrder = sortingLayerHelper;
                    if (Mathf.Abs(transform.position.x - shadowPlace.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - shadowPlace.position.y) <= 0.5f)
                    {
                        transform.position = new Vector2(shadowPlace.position.x, shadowPlace.position.y);
                        winLevel.lockSoundPlay();
                        winLevel4part.lockSoundPlay();
                        winLevel5part.lockSoundPlay();


                        locked5 = true;
                    }
                    else
                    {
                        transform.position = initialPosition;
                        if (touchHelper == true)
                        {
                            gameObject.GetComponent<AudioSource>().Play();

                            gameObject.GetComponent<Animator>().Play("Shake", -1, 0f);
                            touchHelper = false;
                        }
                    }
                    break;
            }


        }
    }
    public void colliderDisable()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        colliderHelperCheck = 1;
    }

    public void colliderEnable()
    {
        GetComponent<BoxCollider2D>().enabled = true;
        colliderHelperCheck = 0;
    }
}
