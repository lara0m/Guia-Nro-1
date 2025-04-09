using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeladeriaTresGustos : MonoBehaviour
{
    // 1. Declarar las variables
    public string codigoGusto;
    public int gramosHelado;

    float precioPorMilGramos = 500;
    float precioTotal;
    float porcentajeDescuento;


    // Start is called before the first frame update
    void Start()
    {
        // 2. Ingreso y validación de datos
        if (gramosHelado < 250 || gramosHelado > 3000)
        {
            Debug.Log("Cantidad de helado no válida");
            return; // Sale de la función, y la continua
        }

        if(codigoGusto == "CHO" || codigoGusto == "DDL")
        {
            porcentajeDescuento = 0;
        }else if (codigoGusto == "FRU")
        {
            porcentajeDescuento = 10;
        }
        else
        {
            Debug.Log("Codigo gusto no valido");
            return;
        }
        
        // 3. Procesamiento de datos (hacer las operaciones)

        precioTotal = gramosHelado * 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
