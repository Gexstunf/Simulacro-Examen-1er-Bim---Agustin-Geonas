using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heladeria : MonoBehaviour
{
    public string sabor;
    public float gramos;
    float precio = 1250f;
    float resultado;
    float fraccion;
    float porcentaje;


    // Start is called before the first frame update
    void Start()
    {
        if (sabor != "CHO" && sabor != "FRU" && sabor != "DDL")
        {
            Debug.Log("Debe ser un sabor entre DDL, CHO, FRU");
            return;
        }
        else if (gramos < 250f || gramos > 3000f)
        {
            Debug.Log("Error gramos debe estar entre 250 y 3000");
            return;
        }
        else if (gramos >= 250f || gramos <= 3000f)
        {
            if (sabor == "FRU")
            {
                fraccion = gramos / 1000f;
                porcentaje = precio / 10f;
                resultado = fraccion * precio;
                resultado -= porcentaje;
                Debug.Log(resultado);
            }
            else
            {
                fraccion = gramos / 1000f;
                resultado = fraccion * precio;
                Debug.Log(resultado);
            }

        }
    }
}
