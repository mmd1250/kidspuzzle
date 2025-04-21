using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts_Particle : MonoBehaviour
{
    public ParticleSystem Bubble_Particle1;
    public ParticleSystem Bubble_Particle2;
    public ParticleSystem Bubble_Particle3;
    public ParticleSystem Bubble_Particle4;
    public ParticleSystem Bubble_Particle5;
    public GameObject part1;
    public GameObject part2;
    public GameObject part3;
    public GameObject part4;
    public GameObject part5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bubble_Particle1.transform.position = part1.transform.position;
        Bubble_Particle2.transform.position = part2.transform.position;
        Bubble_Particle3.transform.position = part3.transform.position;
        if (Bubble_Particle4 != null && part4 != null)
        {
        Bubble_Particle4.transform.position = part4.transform.position;
        }
        if (Bubble_Particle5 != null && part5 != null)
        {
        Bubble_Particle5.transform.position = part5.transform.position;
        }
    }
}
