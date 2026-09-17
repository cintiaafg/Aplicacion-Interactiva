using UnityEngine;

public class logicaEnlacesWeb : MonoBehaviour
{   void Start()
    {
        // Puedes agregar cualquier lógica de inicialización aquí si es necesario
    }
    void Update()
    {
        // Puedes agregar cualquier lógica de actualización aquí si es necesario
    }
    public void EnlacesdeBoton(string enlace)
    {
        Application.OpenURL(enlace);
    }
   
}
