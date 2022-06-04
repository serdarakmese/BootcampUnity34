using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace StarterAssets
{
public class Spider : MonoBehaviour
{
    public float spiderHP;
    bool spiderDead;
    Animator spiderAnim;
    public GameObject tas;
    public GameObject hedef;
    public float kovalamaMesafe;
    public float saldirmaMesafe;
    float mesafe;
    NavMeshAgent spiderNav;
   
    void Start()
    {
        spiderAnim=this.GetComponent<Animator>();
        spiderNav=this.GetComponent<NavMeshAgent>();
    }

    private void OnTriggerEnter(Collider other) 
    {
        if(tas.gameObject)
        {
            spiderHP-=35;
        }  
    }
    
     void Update()
    {
        
        
        if (spiderHP<=0)
        {
            spiderDead= true;
        }    
        
        if(spiderDead==true)
        {
            spiderAnim.SetBool("SpiderDead", true);
            StartCoroutine(SpiderSil());
        }

        else
        {
            mesafe = Vector3.Distance(this.transform.position, hedef.transform.position);
            if(mesafe<kovalamaMesafe)
            {
                spiderNav.isStopped=false;
                spiderNav.SetDestination(hedef.transform.position);
                spiderAnim.SetBool("Walk", true);
                spiderAnim.SetBool("Attack", false);
                
            }
            else
            {
                spiderNav.isStopped=true;
                spiderAnim.SetBool("Walk", false);
                spiderAnim.SetBool("Attack", false);
            }
            if(mesafe<saldirmaMesafe)
            {
                spiderAnim.SetBool("Walk", false);
                spiderAnim.SetBool("Attack", true);
                
            }

        }
        
    }

    public void HasarVer()
    {
        hedef.GetComponent<ThirdPersonController>().HasarAl();
    }

    IEnumerator SpiderSil()
    {
        yield return new WaitForSeconds(5);
        Destroy(this.gameObject);
    }

    

}
}
