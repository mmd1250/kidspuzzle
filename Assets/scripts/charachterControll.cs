using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charachterControll : MonoBehaviour
{

    [SerializeField]
    GameObject bride;
    [SerializeField]
    GameObject groom;
    [SerializeField]
    float moveSpeed;

    public int index;
    int spacehelper;

    private GameObject[] players = new GameObject[2];


    void Awake()
    {
        players[0] = bride;
        players[1] = groom;
        index = 0;
        spacehelper = 0;
    }


    void Update()
    {
        selectPlayer();

        movePlayer();



        if (Input.GetKeyUp(KeyCode.Space))
        {
            spacehelper = 0;
        }

    }

    public void movePlayer()
    {
        players[index].transform.Translate(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime, players[index].transform.position.z);

    }


    public void selectPlayer()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (index == 0 && spacehelper == 0)
            {
                index++;
               
                spacehelper = 1;


            }
            else if (index == 1 && spacehelper == 0)
            {
                index--;
              
                spacehelper = 1;
            }

        }

    }


}
