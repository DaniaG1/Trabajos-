using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlPersonale : MonoBehaviour
{
    //Animator controler
    public float velocidadP = 3.0f;
    public float rotarP = 50.0f;
    public float px, py;
    private Animator miAnin;

    // Start is called before the first frame update
    void Start()
    {
        miAnin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       px = Input.GetAxis("Horizontal");
       py = Input.GetAxis("Vertical");

        transform.Translate(0, 0, py * Time.deltaTime * velocidadP);

        //Calcular el desplazamiento para girar
        transform.Rotate(0, px * Time.deltaTime * rotarP, 0);

        //Acceder a los parametros del animation controller.
        miAnin.SetFloat("velx", px);
        miAnin.SetFloat("vely", py);

    }
}
