using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Clonarglobos : MonoBehaviour
{
    public GameObject Globo;

    public Transform lanzador;

    private float timer = 60;

    [SerializeField]
    [Range(1, 10)]
    private float segundos = 4;

    // Start is called before the first frame update

    // Update is called once per frame

    void Update()
    {
        timer += 1;
        if (timer >= segundos * 60)
        {
            Instantiate(Globo, lanzador.position, Quaternion.identity);
            timer = 0;
        }
        if (timer > 600)
        {
            timer = 0;
        }
    }
}
