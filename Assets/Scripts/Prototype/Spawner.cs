using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public ICopyable n_Copy;
    public Flower SpawnFlower(Flower prototype)
    {
        n_Copy = prototype.Copy();
        return (Flower) n_Copy;
    }
}
