using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntaje : MonoBehaviour
{
    public static int puntaje = 0;
    public Text Marcador;
    // Start is called before the first frame update
    void Start()
    {
        Marcador.text = puntaje.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        Marcador.text = puntaje.ToString();
    }
}
