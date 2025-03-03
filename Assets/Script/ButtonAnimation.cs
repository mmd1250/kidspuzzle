using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonAnimation : MonoBehaviour
{
    Button Btn;
    Vector3 upScale = new Vector3(2f,2f,1);
    Vector3 scale = new Vector3(1.5f,1.5f,1);

    private void Awake()
    {
        Btn = gameObject.GetComponent<Button>();
        Btn.onClick.AddListener(Anim);
    }
    void Anim()
    {
        LeanTween.scale(gameObject, upScale, 0.1f);
        LeanTween.scale(gameObject, scale, 0.1f).setDelay(0.1f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
