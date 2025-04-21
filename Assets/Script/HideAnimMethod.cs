using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAnimMethod : MonoBehaviour
{
    // Start is called before the first frame update

    void IsDestroyed()
    { 
        gameObject.SetActive(false);
    }

}
