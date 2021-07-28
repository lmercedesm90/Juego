using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    [Range(1, 30)]
    private float speed = 1;
    public GameObject objetivo;

    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * speed * -1 * Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        Destroy(gameObject);
    }
}
