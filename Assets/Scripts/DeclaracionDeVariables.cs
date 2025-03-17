using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeclaracionDeVariables : MonoBehaviour
{
    int cantidadAlumnos;
    float largoMesaEnM;
    string domicilioUsuario;
    bool aceptaCondiciones;

    // Start is called before the first frame update
    void Start()
    {
        cantidadAlumnos = 28;
        largoMesaEnM = 1.70f;
        domicilioUsuario = "Libertador 5670";
        aceptaCondiciones = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
