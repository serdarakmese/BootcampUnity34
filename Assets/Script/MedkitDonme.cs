using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedkitDonme : MonoBehaviour
{
    Transform haraket;
    void Start()
    {
        haraket=gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        haraket.Rotate(0,0,1);
    }

    void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.tag=="Player")
        {
            Destroy(this.gameObject);
            Debug.Log("Can +20 eklendi");
        }
    }
}
