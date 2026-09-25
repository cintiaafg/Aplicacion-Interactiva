using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("¡COLISIÓN DETECTADA!");

        if (other.gameObject.name == "ZonaControl")
        {
            Debug.Log("¡EL ROBOT TOCÓ EL CONTROL!");
        }
    }
}
