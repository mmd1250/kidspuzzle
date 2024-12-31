using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class part1 : MonoBehaviour
{

    [SerializeField]
    private Transform shadowPlace;
    private Vector2 initialPosition;
    private float deltaX, deltaY;
    public static bool locked1;
    public static bool touchLockPart1;
    private Vector2 boxColliderInit;
    private int sortingLayerHelper;
    public static bool colliderHelper;
    private int colliderHelperCheck;
    private Animator Shake;

    public bool touchHelper;




    // test
    public float
    clampMarginMinX = 0.0f,
    clampMarginMaxX = 0.0f,
    clampMarginMinY = 0.0f,
    clampMarginMaxY = 0.0f;

    // The minimum and maximum values which the object can go
    private float
        m_clampMinX,
        m_clampMaxX,
        m_clampMinY,
        m_clampMaxY;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
        touchLockPart1 = false;
        boxColliderInit = GetComponent<BoxCollider2D>().size;
        sortingLayerHelper = GetComponent<SpriteRenderer>().sortingOrder;
        colliderHelper = true;
        colliderHelperCheck = 0;
        //Shake = gameObject.GetComponent<Animator>();
        gameObject.GetComponent<Animator>().StopPlayback();

        touchHelper = false;


        m_clampMinX = Camera.main.ScreenToWorldPoint(new Vector2(0 + clampMarginMinX, 0)).x;
        m_clampMaxX = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width - clampMarginMaxX, 0)).x;
        m_clampMinY = Camera.main.ScreenToWorldPoint(new Vector2(0, 0 + clampMarginMinY)).y;
        m_clampMaxY = Camera.main.ScreenToWorldPoint(new Vector2(0, Screen.height + clampMarginMaxY)).y;

        //gameObject.GetComponent<Animator>().enabled = false;
    }


    // Update is called once per frame
    void Update()
    {
        //Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        //pos.x = Mathf.Clamp(pos.x, 0.1f, 0.9f);
        //pos.y = Mathf.Clamp(pos.y, 0.1f, 0.9f);
        //transform.position = Camera.main.ViewportToWorldPoint(pos);

        if (!colliderHelper)
        {
            colliderDisable();
            
        }

        if(colliderHelper && colliderHelperCheck == 1)
        {
            colliderEnable();
        }

        if(Input.touchCount > 0 && !locked1 )
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
      

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos) )
                    {
                        touchHelper = true;
                        deltaX = touchPos.x - transform.position.x;
                        deltaY = touchPos.y - transform.position.y;
                        GameController.lockPart1();
                        GetComponent<BoxCollider2D>().size = new Vector2(40f, 40f);
                    }
                    break;

                case TouchPhase.Moved:

                    if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos)  )
                    {
                        GetComponent<SpriteRenderer>().sortingOrder = 10;
                        transform.position = new Vector2(touchPos.x - deltaX, touchPos.y - deltaY);


                    }
                    break;

                case TouchPhase.Ended:
                    GameController.unlockParts();
                    GetComponent<BoxCollider2D>().size = boxColliderInit;
                    GetComponent<SpriteRenderer>().sortingOrder = sortingLayerHelper;
                    if (Mathf.Abs(transform.position.x - shadowPlace.position.x) <= 0.5f &&
                        Mathf.Abs(transform.position.y - shadowPlace.position.y) <=0.5f)
                    {
                        transform.position = new Vector2(shadowPlace.position.x, shadowPlace.position.y);
                        winLevel.lockSoundPlay();
                        winLevel4part.lockSoundPlay();
                        winLevel5part.lockSoundPlay();



                        locked1 = true;
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
