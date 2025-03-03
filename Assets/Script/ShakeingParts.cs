using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeingParts : MonoBehaviour
{
    private bool Shaking = true;
    [SerializeField]
    private float ShakeAmt;


    private void Update()
    {
        if (Shaking)
        {
            Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * ShakeAmt);
            newPos.z = transform.position.z;

            transform.position = newPos;
            ShakeMe();
        }
    }
    public void ShakeMe()
    {
        StartCoroutine(ShakeNow());
    }

    IEnumerator ShakeNow()
    { 
        Vector3 OriginalPos = transform.position;
        if (Shaking == false)
        {
            Shaking = true;
        }
        yield return new WaitForSeconds(2f);

        Shaking = false;
        transform.position = OriginalPos;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
