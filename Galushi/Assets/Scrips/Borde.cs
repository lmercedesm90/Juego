using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borde : MonoBehaviour
{
    public GameObject nave;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Alien")
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
            Destroy(nave);
            GameOver.Game_Over();
        }

    }
}
