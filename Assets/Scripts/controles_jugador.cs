using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controles_jugador : MonoBehaviour
{
    private float[] carriles = { -3f, 0f, 3f };

    private int carrilActual = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.LeftArrow))
     {
        if(carrilActual > 0)
        {
            carrilActual--;
            ActualizarPosicion();
        }
     }
     if (Input.GetKeyDown(KeyCode.RightArrow))
     {
        if (carrilActual < 2)
        {
            carrilActual++;
            ActualizarPosicion();
        }
     }
    }
    void ActualizarPosicion()
    {
        Vector3 nuevaPos = transform.position;
        nuevaPos.x = carriles[carrilActual];
        transform.position = nuevaPos;
    }
}
