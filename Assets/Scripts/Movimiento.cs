using UnityEngine;

public class Movimiento : MonoBehaviour 
{
    private float velocidadMov = 5f;
    private float fuerzaRebote  = 10f;

	private Vector3 direccionActual;
	private Rigidbody rb;

	private void Start()
	{
		rb = GetComponent<Rigidbody>();
		direccionActual = new Vector3(Random.Range(-1f, 1f), 0, Random.Range(-1f, 1f)).normalized;
	}
	private void FixedUpdate()
	{
		rb.MovePosition(rb.position + direccionActual * velocidadMov * Time.fixedDeltaTime);
	}


	void OnCollisionEnter(Collision collision) { 
	
		if (collision.gameObject.CompareTag("Pared"))
		{
			Rebotar(collision);
		}
		else
		{
			Rebotar(collision);
		}
	}

	void Rebotar(Collision collision)
	{
		Vector3 normalContacto = collision.contacts[0].normal;
		direccionActual = Vector3.Reflect(direccionActual, normalContacto).normalized;
	}

	 
}
