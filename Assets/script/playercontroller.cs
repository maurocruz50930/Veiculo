using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class playercontroller : MonoBehaviour
{
    public float moveSpeed = 10.0f; // Velocidade de movimento do carro
    public float turnSpeed = 100.0f; // Velocidade de rotação do carro

    private void Update()
    {
        // Movimento para frente e para trás
        float verticalInput = Input.GetAxis("Vertical");
        float moveAmount = verticalInput * moveSpeed * Time.deltaTime;
        transform.Translate(Vector3.forward * moveAmount);

        // Rotação esquerda e direita
        float horizontalInput = Input.GetAxis("Horizontal");

        // Verifica se o carro está se movendo antes de aplicar a rotação
        if (Mathf.Abs(verticalInput) > 0.1f)
        {
            float turnAmount = horizontalInput * turnSpeed * Time.deltaTime;
            transform.Rotate(Vector3.up * turnAmount);
        }
    }
}