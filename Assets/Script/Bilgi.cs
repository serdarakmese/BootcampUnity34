using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bilgi : MonoBehaviour
{
    public GameObject toestPanel;
    public Text toestText;
    float sayac;
    bool isToesting;
    void Start()
    {
        TestMesaj("Yerden Taş Almak İçin Sağ Mouse Click'e Basılı Tut ve Düşmana Nişan Alıp Sol Mouse Click ile Taşı Fırlat.",15);
    }

    // Update is called once per frame
    void Update()
    {
        if(isToesting)
        {
            sayac-=Time.deltaTime;
            if(sayac<0){toestPanel.SetActive(false);
            isToesting=false;}
        }
    }

    void TestMesaj(string mesaj, float sure)
    {
        toestText.text=mesaj;
        isToesting=true;
        sayac=sure;
        toestPanel.SetActive(true);
    }
}
