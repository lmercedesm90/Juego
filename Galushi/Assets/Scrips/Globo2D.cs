using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo2D : MonoBehaviour
{
    private float speed = 20;
    private Rigidbody2D rb;
    private Vector2 starPosition;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        starPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 elio = new Vector2(0, speed);
        rb.AddForce(elio);
    }
}
