using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fare : MonoBehaviour
{
    public float fareHP;
    bool fareOlu;
    Animator fareAnim;
    public GameObject tas;
    void Start()
    {
        fareAnim=this.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(tas.gameObject)
        {
            fareHP-=100;
        }  
    }
    
     void Update()
    {
        
        if (fareHP<=0)
        {
            fareOlu= true;
        }    
        
        if(fareOlu==true)
        {
            fareAnim.SetBool("fareoldu", true);
            StartCoroutine(FareSil());
        }
        
    }

    IEnumerator FareSil()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }

    public void HasarAl()
    {
        fareHP-=(100);
    }

}
