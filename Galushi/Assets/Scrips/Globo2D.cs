using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globo2D : MonoBehaviour
{
    [SerializeField]
    [Range(1, 15)]
    private float speed = 1;
    private Rigidbody2D rb;
    private Vector2 starPosition;
    // Start is called before the first frame update

    AudioSource audioSource;
    public Sprite spritechange;
    private SpriteRenderer sprite;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        starPosition = transform.position;
        sprite = gameObject.GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 elio = new Vector2(0, speed);
        rb.AddForce(elio);
    }

    void OnCollisionEnter2D(Collision2D hit)
    {
        if (hit.transform.gameObject.name == "Lazer(Clone)")
        {
            Debug.Log("exploto");
            audioSource.Play();
            sprite.sprite = spritechange;
            transform.position = new Vector2(0, 6);
            Destroy(gameObject, 1);
        }
        else
        {
            Debug.Log("exploto bordes");
            Destroy(gameObject);   
        }
    }

}
