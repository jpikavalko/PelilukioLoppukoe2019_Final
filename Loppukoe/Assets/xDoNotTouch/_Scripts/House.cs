using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    [HideInInspector]
    public GameObject flag;
    [HideInInspector]
    public Sprite[] doors;
    [HideInInspector]
    public Sprite[] flags;

    SpriteRenderer flagRend, doorUpRend, doorDownRend;

    [HideInInspector]
    public bool IsReferenceCorrect { get; set; } //= false;
    

    private void Awake()
    {
        IsReferenceCorrect = false;
        flagRend = flag.GetComponent<SpriteRenderer>();
        doorUpRend = transform.GetChild(0).GetComponent<SpriteRenderer>();
        doorDownRend = transform.GetChild(1).GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.name);

        if (IsReferenceCorrect)
        {
            OpenDoors();
            InvokeRepeating("WaveTheFlag", 0f, 0.25f);
        }
    }

    private void OpenDoors()
    {
        doorUpRend.sprite = doors[0];
        doorDownRend.sprite = doors[1];
    }

    private void WaveTheFlag()
    {
        if (flagRend.sprite == flags[1])
        {
            flagRend.sprite = flags[2];
        }
        else
        {
            flagRend.sprite = flags[1];
        }
    }
}
