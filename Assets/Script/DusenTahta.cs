using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DusenTahta : MonoBehaviour
{
    public GameObject tahta;
    public GameObject faketahta;

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.tag=="Player")
        {
            tahta.SetActive(true);
            Destroy(faketahta);
        }
    }
}
