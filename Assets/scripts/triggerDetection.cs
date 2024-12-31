using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerDetection : MonoBehaviour
{
    [SerializeField] GameObject switchF;
    [SerializeField] GameObject key;
    [SerializeField] GameObject moveBox;
    bool triggerEntered = false;
    bool boxTrigger = false;



    public Transform BoxHolder;



    private void Start()
    {

    }
    private void Update()
    {
        //باز کردن در یا کلید فعال کردن
        if (Input.GetKeyDown(KeyCode.E) && triggerEntered == true)
        {
            Debug.Log("interact");
            key.transform.position = new Vector2(key.transform.position.x + 2, key.transform.position.y);
        }



        //برای نگه داری جعبه ها
        if (Input.GetKey(KeyCode.E) && boxTrigger == true)
        {

            moveBox.gameObject.transform.parent = BoxHolder;
            moveBox.gameObject.transform.position = BoxHolder.position;
        }
        if (Input.GetKeyUp(KeyCode.E) && boxTrigger == false)
        {

            moveBox.gameObject.transform.parent = null;
        }

    }


    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "KEY")
        {
            triggerEntered = true;
            switchF.SetActive(true);
        }

        if (col.gameObject.tag == "BOXER")
        {
            boxTrigger = true;

        }



    }
    private void OnTriggerExit2D(Collider2D col)
    {

        if (col.gameObject.tag == "KEY")
        {
            triggerEntered = false;
            switchF.SetActive(false);
        }
        if (col.gameObject.tag == "BOXER")
        {
            boxTrigger = false;

        }


    }



}
