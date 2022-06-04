using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cakardonme : MonoBehaviour
{
    Transform donme;
    void Start()
    {
        donme = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        donme.Rotate(0,3,0);
    }
}
