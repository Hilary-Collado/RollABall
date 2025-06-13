using UnityEngine;

public class CamaraController : MonoBehaviour
{
    public GameObject jugador;
    private Vector3 offset;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - jugador.transform.position;   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = jugador.transform.position + offset;
    }
}
