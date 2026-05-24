using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour
{
    public float vel_bala;

    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * vel_bala * Time.deltaTime;

    }
    private void OnCollisionEnter2D(Collision2D otroObjeto)
    {
        if (otroObjeto.gameObject.tag =="Asteroide")
        {
            
            Destroy(otroObjeto.gameObject);
            Destroy(gameObject);
        }
    }



}
