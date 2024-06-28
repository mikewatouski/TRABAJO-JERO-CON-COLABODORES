using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerScript : MonoBehaviour
{
    public GameObject[] objetos1;
    public GameObject[] objetos2;

     private int precioObjeto1;
    private int precioObjeto2;
    private int dineroJugador;

    public Text objeto1Text;
    public Text objeto2Text;
    public Text dineroText;
    // Start is called before the first frame update
    void Start()
    {
        DesactivarObjetos();
        RandomizarValores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     void DesactivarObjetos()
    {
        foreach (GameObject obj in objetos1)
        {
            obj.SetActive(false);
        }
                foreach (GameObject obj in objetos2)
        {
            obj.SetActive(false);
        }
    }
    void RandomizarValores()
    {
        
        int indexObjeto1 = Random.Range(0, objetos1.Length);
        int indexObjeto2 = Random.Range(0, objetos2.Length);
        
        objetos1[indexObjeto1].SetActive(true);
        objetos2[indexObjeto2].SetActive(true);

        precioObjeto1 = Random.Range(1, 101); 
        precioObjeto2 = Random.Range(1, 101);

        dineroJugador = Random.Range(1, 201);

         objeto1Text.text = "Precio: $" + precioObjeto1;
        objeto2Text.text = "Precio: $" + precioObjeto2;
        dineroText.text = "Dinero del jugador: $" + dineroJugador;
    }
}
