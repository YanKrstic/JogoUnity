using UnityEngine;

public class GravPoint : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("foi entrado por: " + other.gameObject.name);

        if (other.CompareTag("Player"))
        {
            Debug.Log("Grav colhido");

            ControlePersonagem pc = other.GetComponent<ControlePersonagem>();

            if (pc != null)
            {
                pc.grav = true;
                //pc.healthBar.GetComponent<Image>().color = Color.blue;
                pc.healthBar.UpdateColorBlue();
            }
            else
            {
                Debug.LogWarning("PlayerController não foi encontrado no objeto Player!");
            }

            Destroy(gameObject);
        }
    }
}
