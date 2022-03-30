using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    float Hor;
    public int velocidad;
    public Animator anim;

    void Start()
    {
        velocidad = 4;    
    }

    
    void Update()
    {
        Hor = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        this.transform.Translate(Hor, 0,0);
        anim.SetFloat("velocidad", Mathf.Abs(Hor));
    
        Scale();
    }

    void Scale()
    {
        if (Input.GetKey("a"))
        {
            this.transform.localScale = new Vector2(-5,5);
        }
        if (Input.GetKey("d"))
        {
            this.transform.localScale = new Vector2(5,5);
        }
    
    }
}
