using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningClient : MonoBehaviour
{
    public Jasmine jasmine;
    public Roses roses;
    public Bounds boundingSpawnBox;
    private Flower m_Flower;
    private Spawner m_Spawner;
    private void Start() 
    {
        m_Spawner = new Spawner();
    }

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            m_Flower = m_Spawner.SpawnFlower(jasmine);
            AssignFlowerToPosition(m_Flower);
        }
        else if(Input.GetKeyDown(KeyCode.D))
        {
            m_Flower = m_Spawner.SpawnFlower(roses);
            AssignFlowerToPosition(m_Flower);
        }
    }
    void AssignFlowerToPosition(Flower flower)
    {
        float randX = Random.Range(boundingSpawnBox.center.x, boundingSpawnBox.extents.x);
        float randZ = Random.Range(boundingSpawnBox.center.z, boundingSpawnBox.extents.z);

        Vector3 pos = new Vector3(randX, 0, randZ);
        flower.transform.Translate(pos);
    }
}
