using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumping : MonoBehaviour
{
    //declacion variables
    public float fuerzasalto;//fuerza con la que saltara mi pj
    public float radiopie;//alcance de mi detector
    public Transform pie;//obj pie
    public LayerMask capasuelo;//capa del suelo
    private Rigidbody2D rb;//el cuerpo fisico del obj.
    public bool Suelo = false;//verifica si toque el suelo

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //objeto el rigidbody2d
        radiopie=1.7f;
        fuerzasalto = 12;
    }

    // se ejecutara a medida vas jugando
    void Update()
    {
        Suelo = Physics2D.OverlapCircle(pie.position, radiopie, capasuelo);

        //si presiona w y estoy en el suelo 
        if(Input.GetKey("w") && Suelo == true)
        {
            // salto
            rb.velocity= new Vector2(0,fuerzasalto);
        }


    }
}
