using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxV : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 1f;

    [SerializeField]
    private float n;

    private Vector2 starPosition;

    private float newPosition;

    void Start()
    {
        starPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        newPosition = Mathf.Repeat(Time.time * -speed, n);
        transform.position = starPosition + Vector2.down * newPosition;
    }
}
