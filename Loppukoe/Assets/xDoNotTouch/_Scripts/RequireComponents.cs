using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RequireComponents : MonoBehaviour
{

    BoxCollider2D boxCol;
    CircleCollider2D circleCol;
    Light lightComponent;
    Rigidbody2D rigidBody;
    AudioSource audioSource;
    LineRenderer lineRenderer;
    ParticleSystem particle;
    SpringJoint2D spring;
    MeshFilter meshFilter;
    MeshRenderer meshRenderer;

    private void Start()
    {
        string studentName = Questions.yourName;
        Crypting crypt = new Crypting(studentName[0], studentName[1], studentName[2]);

        for (int i = 0; i < 3; i++)
        {
            int charToInt;
            charToInt = (int)Char.GetNumericValue(crypt.CryptedNumbers[i]);

            switch (charToInt)
            {
                case 0:
                    try
                    {
                        boxCol = gameObject.GetComponent<BoxCollider2D>();
                        boxCol.enabled = true;
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Box Collider not found");
                    }
                    
                    break;

                case 1:
                    try
                    {
                        circleCol = gameObject.GetComponent<CircleCollider2D>();
                        circleCol.enabled = true;
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Circle Collider not found");
                    }
                    
                    break;
                    
                case 2:
                    try
                    {
                        audioSource = gameObject.GetComponent<AudioSource>();
                        audioSource.enabled = true;
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Audio Source not found");
                    }
                    
                    break;

                case 3:
                    try
                    {
                        lightComponent = gameObject.GetComponent<Light>();
                        lightComponent.enabled = true;
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Light not found");
                    }
                    
                    break;

                case 4:
                    try
                    {
                        rigidBody = gameObject.GetComponent<Rigidbody2D>();
                        rigidBody.velocity = new Vector2(0, 0);
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("RigidBody not found");
                    }
                    
                    break;

                case 5:
                    try
                    {
                        particle = gameObject.GetComponent<ParticleSystem>();
                        particle.Play();
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Particle System not found");
                    }
                    
                    break;

                case 6:
                    try
                    {
                        lineRenderer = gameObject.GetComponent<LineRenderer>();
                        lineRenderer.enabled = true;
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Line Renderer not found");
                    }
                    
                    break;

                case 7:
                    try
                    {
                        spring = gameObject.GetComponent<SpringJoint2D>();
                        spring.enabled = true;
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Sping Joint not found");
                    }
                    
                    break;
                    ;

                case 8:
                    try
                    {
                        meshRenderer = gameObject.GetComponent<MeshRenderer>();
                        meshRenderer.enabled = true;
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Mesh Renderer not found");
                    }
                    
                    break;

                case 9:
                    try
                    {
                        meshFilter = gameObject.GetComponent <MeshFilter>();
                        meshFilter.mesh = new Mesh();
                        Debug.Log(Crypting.DoMagicToNumber(charToInt));
                    }
                    catch (Exception e)
                    {
                        Debug.LogError(e);
                        Debug.LogWarning("Mesh Filter not found");
                    }
                    
                    break;
            }
        }
    }
}


