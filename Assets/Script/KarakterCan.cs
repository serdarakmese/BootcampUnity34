using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StarterAssets
{
public class KarakterCan : MonoBehaviour
{
    public ThirdPersonController thirdPersonController;
    public float can;
    public Spider spider;
	private bool death;
    
   
    void Start()
    {
       
    }

    
    void Update()
    {
        if (can<=0)
        {
            death= true;
        }    else death=false;
		

        if(death==true)
        {
            thirdPersonController._animator.SetBool("Death", true);
        }
		else
		thirdPersonController._animator.SetBool("Death", false);
        
    }
    void OnTriggerEnter(Collider other) 
		{
			if (other.gameObject.tag=="Water")
			{
				can=-100;
                
			}
}
}
}