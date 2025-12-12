using UnityEngine;

public class GravPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("foi entrado por: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Grav colhido");

            // Pegando o componente do Player
            ControlePersonagem pc = other.GetComponent<ControlePersonagem>();

            // Verificando se ele existe
            if (pc != null)
            {
                pc.grav = true;  // ✔ Agora você altera a variável
            }
            else
            {
                Debug.LogWarning("PlayerController não foi encontrado no objeto Player!");
            }

            Destroy(gameObject);
        }
    }
}
