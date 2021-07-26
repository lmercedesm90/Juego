using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Lanzador;

    public GameObject Lazer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Instantiate(Lazer, Lanzador.position, Quaternion.identity);
        }
    }
}
