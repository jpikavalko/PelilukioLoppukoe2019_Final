using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RequireComponents : MonoBehaviour
{
    BoxCollider2D boxCol;
    CircleCollider2D circleCol;
    Light light;
    Rigidbody2D rigidBody;
    AudioSource audioSource;
    LineRenderer lineRenderer;
    ParticleSystem particle;
    private void Start()
    {
        switch (gameObject.name)
        {
            case "Aita":
                boxCol = GetComponent<BoxCollider2D>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Avain":
                circleCol = GetComponent<CircleCollider2D>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Kolikko":
                audioSource = GetComponent<AudioSource>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Kyltti":
                lineRenderer = GetComponent<LineRenderer>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Laatikko":
                boxCol = GetComponent<BoxCollider2D>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Lippu":
                particle = GetComponent<ParticleSystem>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Lukko":
                lineRenderer = GetComponent<LineRenderer>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Otus":
                audioSource = GetComponent<AudioSource>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Soihtu":
                light = GetComponent<Light>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;
            case "Tatti":
                circleCol = GetComponent<CircleCollider2D>();
                rigidBody = GetComponent<Rigidbody2D>();
                break;

        }
    }

}
