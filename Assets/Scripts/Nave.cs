using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nave : MonoBehaviour
{
    public float velocidad;
    Rigidbody2D rb;
    public GameObject balaPrefab;
  

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    { //Depende de los FPS

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(balaPrefab, this.transform.position, Quaternion.identity);
        }
        
    }
    private void FixedUpdate()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");
        rb.MovePosition(rb.position + new Vector2(movimientoHorizontal, movimientoVertical) * velocidad * Time.deltaTime);

        ////para fisicas - no depende de los FPS
        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    //transform.position += Vector3.right * Time.deltaTime * velocidad;
        //    rb.velocity += Vector2.right * Time.deltaTime * velocidad;
        //}
        //else
        // if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    //transform.position += Vector3.left* Time.deltaTime * velocidad;
        //    rb.velocity += Vector2.left * Time.deltaTime * velocidad;

        //}
        //if (Input.GetKey(KeyCode.UpArrow))
        //{
        //    transform.position += Vector3.up * Time.deltaTime * velocidad;
        //    //(0,1,0)
        //    //rb.velocity += Vector2.up * Time.deltaTime * velocidad;
        //}
        //else
        //    if (Input.GetKey(KeyCode.DownArrow))
        //{
        //    transform.position += Vector3.down * Time.deltaTime * velocidad;
        //    //(0,-1,0)
        //    //  rb.velocity += Vector2.down * Time.deltaTime * velocidad;
        //}
    }

}
