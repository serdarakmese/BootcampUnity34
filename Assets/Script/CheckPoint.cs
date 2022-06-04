using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
public class CheckPoint : MonoBehaviour
{
    public ThirdPersonController thirdPersonController;
    void Start()
    {
        
    }

    // Update is called once per frame
   void OnTriggerEnter(Collider other) 
   {
       if(other.gameObject.tag=="Player")
       {
           thirdPersonController.checkpos=other.transform.position;
           thirdPersonController.saglik=+100;
           thirdPersonController.trigger1.SetActive(false);
       }

       
   }
}
}