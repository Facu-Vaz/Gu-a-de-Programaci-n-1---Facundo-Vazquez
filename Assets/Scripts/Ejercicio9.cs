using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio9 : MonoBehaviour
{
    public string nombre1;
    public float capital1;
    public string nombre2;
    public float capital2;
    public string nombre3;
    public float capital3;

    void Start()
    {
        float total_capital = capital1 + capital2 + capital3;
        Debug.Log("Nombre: " + nombre1 + " | Capital aportado: $" + capital1 + " | Porcentaje del capital: %" + ((capital1 / total_capital) * 100));
        Debug.Log("Nombre: " + nombre2 + " | Capital aportado: $" + capital2 + " | Porcentaje del capital: %" + ((capital2 / total_capital) * 100));
        Debug.Log("Nombre: " + nombre3 + " | Capital aportado: $" + capital3 + " | Porcentaje del capital: %" + ((capital3 / total_capital) * 100));
        Debug.Log("Monto total aportado: " + total_capital);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
