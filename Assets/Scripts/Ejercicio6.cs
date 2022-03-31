using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0
//en una variable llamada num1 y muestre un mensaje por pantalla indicando "el número es
//par" o "el número es impar". Deberá utilizar el operador “módulo” es el caracter %.


public class Ejercicio6 : MonoBehaviour
{
    public int num1;
    void Start()
    {
        if (num1 % 2 == 0)
        {
            Debug.Log("el número es par");
        }
        else
        {
            Debug.Log("el número es impar");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
