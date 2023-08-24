using UnityEngine.UI;
using UnityEngine;

public class Farmer : MonoBehaviour, INPC
{
    public Text stats;
    public GameObject bubble;
    public void Speak()
    {
        bubble.SetActive(true);
        stats.text = "You gonna help me harvest the crops young man!";
    }
     public void DestroyNPC()
    {
        Destroy(gameObject);
    }
}
