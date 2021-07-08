using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    [Range(1, 30)]
    public float speed = 10f;
    [Range(1, 15)]
    public float potencia = 10f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Capturo el movimiento en horizontal y vertical de nuestro teclado
        float movimientoH = Input.GetAxisRaw("Horizontal");
        float movimientoV = Input.GetAxisRaw("Vertical");

        //Genero el vector de movimiento asociado, teniendo en cuenta la velocidad
        Vector2 movimiento = new Vector2(movimientoH * speed, movimientoV * potencia);

        //Aplico ese movimiento al RigidBody del jugador
        rb.velocity = movimiento;
    }
}
