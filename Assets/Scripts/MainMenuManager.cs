using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
	
	public void CargarJuego()
	{
		Debug.Log("Cargando Level 1...");
		SceneManager.LoadScene("Level 1");
	}

	public void CargarNivelEspecifico(int numeroDeNivel)
	{
		Debug.Log("Cargando Level " + numeroDeNivel + "...");

		SceneManager.LoadScene("Level" + numeroDeNivel);
	}


	public void AbrirOpciones()
	{
		Debug.Log("Abriendo Opciones...");
		SceneManager.LoadScene("Opciones");
	}

	public void SalirJuego()
	{
		Debug.Log("Saliendo del juego...");
		Application.Quit(); 
	}
}
