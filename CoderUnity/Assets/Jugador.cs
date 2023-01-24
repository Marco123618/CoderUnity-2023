using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public int vida = 50;
    public Vector3 posicion;
    public Vector3 rot;
    public Vector3 escala;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(vida);
        Debug.Log(transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(posicion);
        transform.Rotate(rot);
        transform.localScale += escala;
    }
}
