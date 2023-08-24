using UnityEngine.UI;
using UnityEngine;

public class Casual : MonoBehaviour, INPC
{
    public Text stats;
    public GameObject bubble;
    public void Speak()
    {
        bubble.SetActive(true);
        stats.text = "Hello there!\nHow is it going?";
    }
     public void DestroyNPC()
    {
        Destroy(gameObject);
    }
}
