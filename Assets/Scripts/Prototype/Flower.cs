using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flower : MonoBehaviour, ICopyable
{
    public ICopyable Copy()
    {
        return Instantiate(this);
    }
}
