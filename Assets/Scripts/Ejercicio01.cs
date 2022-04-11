using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio01 : MonoBehaviour
{
    public string animal;
    public int dias;
    // Start is called before the first frame update
    void Start()
    {

        if (dias >= 3)
        {
            if (animal == "G" || animal == "PP" || animal == "PG")
            {
                switch(animal)
                {
                    case "G":
                        Debug.Log("Para ese periodo se necesitan " + (300 * dias) + " gramos de alimento");
                        Debug.Log("El costo seria: $" + ((300 * dias) / 100 * 80));
                        break;

                    case "PP":
                        Debug.Log("Para ese periodo se necesitan " + (400 * dias) + " gramos de alimento");
                        Debug.Log("El costo seria: $" + ((400 * dias) / 100 * 80));
                        break;

                    case "PG":
                        Debug.Log("Para ese periodo se necesitan " + (700 * dias) + " gramos de alimento");
                        Debug.Log("El costo seria: $" + ((700 * dias) / 100 * 80));
                        break;

                }
            }

            else
            {
                Debug.Log("El codigo de animal ingresado NO es valido");
            }
        }

        else
        {
            Debug.Log("Se ingreso una cantidad dias invalida (menor a 3)");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
