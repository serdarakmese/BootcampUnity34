using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DüsenKayalar : MonoBehaviour
{
    public GameObject fake;
    public GameObject kayalar1;
    public GameObject kayalar2;
    public GameObject kayalar3;
    public GameObject kayalar4;
    public GameObject kayalar5;
    public GameObject kayalar6;
    bool calistir;
    void Start()
    {
        
        
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag=="Player")
        {
            kayalar1.SetActive(true);
            kayalar2.SetActive(true);
            kayalar3.SetActive(true);
            kayalar4.SetActive(true);
            kayalar5.SetActive(true);
            kayalar6.SetActive(true);
            Destroy(fake);
        }
    }
}
