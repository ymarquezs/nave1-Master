using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesplazarFondo : MonoBehaviour
{
    public float velocidad;
    private Renderer fondo;
    void Start()
    {
        fondo = GetComponent<Renderer>();
    }

    
    void Update()
    {
        Vector2 desplazamiento = new Vector2( 0, Time.time*velocidad  );
        fondo.material.mainTextureOffset = desplazamiento;
    }
}
