using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Una flota de taxis tiene una cantidad determinada de unidades.Se calcula que cada unidad 
//    recorre unos 90 km por día y que cada litro de combustible permite recorrer 15 km.
//    Se calcula también que los días de lluvia se trabaja más, llegando a un recorrido de 
//    110 km por unidad.Teniendo en cuenta que el litro de combustible cuesta $130, debemos 
//    hacer un programa que nos permita calcular el costo del combustible para una flota 
//    completa de taxis en un período de días determinado.

//Se requiere el ingreso por Inspector de la cantidad total de días y una cantida
//    d de días de lluvia a tener en cuenta.

public class ejercicio1 : MonoBehaviour
{
    public int diasDeLluvia;

    // Start is called before the first frame update
    void Start(){
        Debug.Log("Ingrese la cantidad de dias de lluvia");
        if(diasDeLluvia < 5)
        {
            Debug.Log("Se produjo un error");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
