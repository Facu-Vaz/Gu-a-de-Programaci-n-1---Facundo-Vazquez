using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Crear una variable entera que pueda ser modificada desde el Inspector.
//Suponiendo que el primer día de la semana es el Domingo, mostrar el nombre del día 
//correspondiente al valor de la variable “dia”. Si el día no está en el rango  permitido 
//debe emitir por pantalla el mensaje de error "El día ingresado no es válido". 

public class Ejercicio8 : MonoBehaviour
{
    public int diaSemana;
    void Start()
    {
        int dia = diaSemana--;
        string[] semana = new string[7];
        semana[0] = "Domingo";
        semana[1] = "Lunes";
        semana[2] = "Martes";
        semana[3] = "Miercoles";
        semana[4] = "Jueves";
        semana[5] = "Viernes";
        semana[6] = "Sabado";

        if (dia > 6)
        {
            Debug.Log("El día ingresado no es válido");
        }
        else
        {
            Debug.Log(semana[dia]);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
