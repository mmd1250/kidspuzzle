using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using CafeBazaar.Billing;


public class splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BazaarBilling.Init((result) =>
        {
            if (result.Successful)
            {
                Debug.Log("BazaarBilling is inited.");
            }
            else
            {
                Debug.Log("BazaarBilling Can't init !");
            }
        });
        StartCoroutine(startGame());
        Debug.Log("start splash");
    }

    IEnumerator startGame()
    {

        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Menu");



    }
}
