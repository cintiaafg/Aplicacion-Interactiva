using UnityEngine;

public class MovimientoRobot : MonoBehaviour
{
    public float velocidad = 200f;

    private RectTransform rectTransform;

    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 movimiento = new Vector2(horizontal, vertical);

        rectTransform.anchoredPosition += movimiento * velocidad * Time.deltaTime;
    }
}
