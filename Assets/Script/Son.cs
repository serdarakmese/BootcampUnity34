using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Son : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {if(other.gameObject.tag==("Player"))
        SceneManager.LoadScene("OyunSonu");
    }
}
