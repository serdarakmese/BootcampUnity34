using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;
using UnityEngine.EventSystems;

public class BilgiSahnesineGecis : MonoBehaviour
{
    public void SahneGecis()
    {
        SceneManager.LoadScene("BilgiSahnesi");
    }
}
