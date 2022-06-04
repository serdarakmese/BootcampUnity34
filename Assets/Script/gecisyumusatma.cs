using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gecisyumusatma : MonoBehaviour
{
    public Image karartma;
    void Start()
    {
        karartma.canvasRenderer.SetAlpha(1.0f);
        yumusatma();
    }

    // Update is called once per frame
    void yumusatma()
    {
        karartma.CrossFadeAlpha(0, 5, false);
    }
}
