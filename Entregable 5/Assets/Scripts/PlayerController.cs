using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 initialPos = Vector3.zero;
    public float speed = 10.0f;
    private float verticalInput;
    public float turnSpeed = 20.0f;
    private float zMax = 450f;

    void Start()
    {
        // Empieza en el eje (0,0,0)
        transform.position = Vector3.zero;
    }

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");

        // Movimiento hacia delante
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Rotación
        transform.Rotate(Vector3.right, turnSpeed * Time.deltaTime * verticalInput);

        // Si el avión traspasa el máximo del eje Z (450), se acaba el juego
        if (transform.position.z > zMax)
        {
            Debug.Log(message: "THE END");
            Time.timeScale = 0;
            // Se para el tiempo
        }
    }
}
