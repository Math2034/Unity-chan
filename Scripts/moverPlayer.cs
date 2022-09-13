using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverPlayer : MonoBehaviour
{

    public Rigidbody2D rb;
    public int velocidade;
    private float direcao;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

}

    // Update is called once per frame
    void Update()
    {
        direcao = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(direcao*velocidade, rb.velocity.y);
    }
}
