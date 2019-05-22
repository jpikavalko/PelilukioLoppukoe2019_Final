using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ReferenceLogic : MonoBehaviour
{
    public GameObject[] tipBoxes;
    public GameObject[] prefabs;

    private SpriteRenderer[] tipBoxRenderers;
    private Sprite[] prefabIcons;

    private void Awake()
    {
        tipBoxRenderers = new SpriteRenderer[3];
        for (int i = 0; i < tipBoxes.Length; i++)
        {
            tipBoxRenderers[i] = tipBoxes[i].GetComponent<SpriteRenderer>();
        }

        prefabIcons = new Sprite[prefabs.Length];
        for (int i = 0; i < prefabs.Length; i++)
        {
            prefabIcons[i] = prefabs[i].GetComponent<SpriteRenderer>().sprite;
        }
    }
}
