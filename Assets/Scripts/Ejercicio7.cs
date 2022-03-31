using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Realizá un programa que al ingresar por Inspector tres números enteros num1, num2 y num3,
//muestre el valor del mayor de todos.
//En caso de igualdad entre los tres imprimir "Los números son iguales". 


public class Ejercicio7 : MonoBehaviour
{
    public int num1;
    public int num2;
    public int num3;

    void Start()
    {
        int mayor = num1;
        int indice = 1;
        if (num2 > mayor)
        {
            mayor = num2;
            indice = 2;
        }
        if (num3 > mayor)
        {
            mayor = num3;
            indice = 3;
        }

        if (num1 == num2 && num2 == num3)
        {
            Debug.Log("Los numeros son iguales");
        }
        else
        {
            Debug.Log("El mayor numero es num" + indice);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
