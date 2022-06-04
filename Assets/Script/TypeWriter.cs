using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TypeWriter: MonoBehaviour
{
   [Multiline]
   public string yazı;

   Text thisText;
   public float delay;

   private void Start() 
   {
       thisText=GetComponent<Text>();
       
       StartCoroutine(TypeWrite());    
   }


   IEnumerator TypeWrite()
   {
       foreach(char i in yazı)
       {
           
           thisText.text+=i.ToString();

           if(i.ToString()==".")
           {
               yield return new WaitForSeconds(0.5f);
           }
           else
           {
               yield return new WaitForSeconds (delay);
           } 
       }
   }

   private void OnMouseDown() {
       SceneManager.LoadScene("Level");
   }
}
