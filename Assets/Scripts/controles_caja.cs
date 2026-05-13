using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles_caja : MonoBehaviour
{
    public float speed = 5f;
    public float incrementoVelocidad = 1.1f;
    private float[] posicionesX = { -3f, 0f, 3f };

    private bool juegoActivo = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!juegoActivo) return;
        transform.Translate(0, -speed * Time.deltaTime, 0);
        if (transform.position.y <= 0)
        {
            ReiniciarCaja();
        }
    }
    public void ReiniciarCaja()
    {
        if (!juegoActivo) return;

        int indiceAleatorio = Random.Range(0, posicionesX.Length);
        transform.position = new Vector3(posicionesX[indiceAleatorio], 7f, 0f);
        speed *= incrementoVelocidad;
    }
    public void DetenerCaja()
    {
        juegoActivo = false;
        speed = 0;
        Debug.Log("Juego Detenido: Contacto con Player");
    }
}
