using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        tipBoxes[0].GetComponent<SpriteRenderer>().sprite = prefabIcons[2];
        tipBoxes[1].GetComponent<SpriteRenderer>().sprite = prefabIcons[9];
        tipBoxes[2].GetComponent<SpriteRenderer>().sprite = prefabIcons[8];
    }

    private void Start()
    {
        string studentName = Questions.yourName;
        Crypting crypt = new Crypting(studentName[0], studentName[1], studentName[2]);
        Debug.Log(crypt.CryptedNumbers[0]);
        Debug.Log(crypt.CryptedNumbers[1]);
        Debug.Log(crypt.CryptedNumbers[2]);
    }

}
