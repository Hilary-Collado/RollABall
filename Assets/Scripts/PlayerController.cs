using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using TMPro;
using Unity.VisualScripting;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    public float velocidad;
    private int contador;
    public TMP_Text textoContador, textoGanar;


    public float fuerzaSalto = 15f;
	public float gravedad = -10f;
    public float salto = 2;

    Vector3 VelocidadAbajo;
	private bool enElSuelo;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        contador = 0;
        setTextoContador();
        textoGanar.text = "";
        //enElSuelo = true;
	}
      
    // Update is called once per frame
    void FixedUpdate()
    {
        float movimientoH = Input.GetAxis("Horizontal");
        float movimientoV = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movimientoH, 0.0f, movimientoV);

        rb.AddForce(movimiento*velocidad);
        
        //aqui voy a hacer que salte

  //      if(Input.GetButtonDown("Jump") && enElSuelo)
		//{
		//	rb.AddForce(Vector3.up * fuerzaSalto, ForceMode.Impulse);
		//	enElSuelo = false;
		//}
 
	}

	private void OnTriggerEnter(Collider other)
	{

        if (other.gameObject.CompareTag("Coleccionable"))
        {
            other.gameObject.SetActive(false);
            contador +=1;
            setTextoContador();
        }
	}

    void setTextoContador()
    {
        textoContador.text = "Contador: " + contador.ToString();
        if (contador > 12)
        {
            textoGanar.text = "" +
                "¡Si, Has ganado!";
        }
    }

	//private void OnCollisionEnter(Collision collision)
	//{
	//	//if (collision.gameObject.CompareTag("Suelo"))
	//	//{
	//	//    enElSuelo = true;
	//	//}
	//	Debug.Log("Colisión con: " + collision.gameObject.name);
	//	if (collision.gameObject.CompareTag("Suelo"))
	//	{
	//		enElSuelo = true;
	//	}
	//}

	//private void OnCollisionExit(Collision collision)
	//{
 //       if (collision.gameObject.CompareTag("Suelo"))
 //       {
	//		enElSuelo = false;
	//	}
	//}
}
