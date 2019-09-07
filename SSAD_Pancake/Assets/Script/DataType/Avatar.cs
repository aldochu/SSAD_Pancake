using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Avatar : MonoBehaviour
{
    public string head;
    public string face;
    public string shirt;
    public string pant;

    public Avatar()
    {
    }

    public Avatar(string head, string face, string shirt, string pant)
    {
        this.head = head;
        this.face = face;
        this.shirt = shirt;
        this.pant = pant;
    }
}
