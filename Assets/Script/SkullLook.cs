using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullLook : MonoBehaviour
{
    public GameObject look;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.LookAt(look.transform);
    }
}
