using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControll : MonoBehaviour
{

    void Start()
    {
        
    }

    [SerializeField]
    GameObject PlayB, ExitB, storyPanel;

    [SerializeField]
    Transform targerposA, targerposB, targerposC;

    [SerializeField]
    float T1, T2;

    bool test = false;

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            lerpT();
               
        }
    }


    private void lerpT()
    {
        Vector2 a = PlayB.transform.position;
        Vector2 b = targerposA.position;
        PlayB.transform.position = Vector2.Lerp(a, b, T1);

        Vector2 a2 = ExitB.transform.position;
        Vector2 b2 = targerposB.position;
        ExitB.transform.position = Vector2.Lerp(a2, b2, T1);

        Vector2 a3 = storyPanel.transform.position;
        Vector2 b3 = targerposC.position;
        storyPanel.transform.position = Vector2.Lerp(a3, b3, T2);

    }

    public void PlayGame(string sceneName)
    {
        test = true;
        StartCoroutine(delay(sceneName));
    }




    public IEnumerator delay(string sceneName)
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(sceneName);
    }



    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("qq");
    }
}
