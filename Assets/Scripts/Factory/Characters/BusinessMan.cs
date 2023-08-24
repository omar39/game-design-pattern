using UnityEngine.UI;
using UnityEngine;

public class BusinessMan : MonoBehaviour, INPC
{
    public Text stats;
    public GameObject bubble;
    public void Speak()
    {
        bubble.SetActive(true);
        stats.text = "Hello my friend!\nCheck my Linkedin for job offers.";
    }
     public void DestroyNPC()
    {
        Destroy(gameObject);
    }
}
