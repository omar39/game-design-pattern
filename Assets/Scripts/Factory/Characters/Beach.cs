using UnityEngine.UI;
using UnityEngine;

public class Beach : MonoBehaviour, INPC
{
    public Text stats;
    public GameObject bubble;
    public void Speak()
    {
        bubble.SetActive(true);
        stats.text = "Hello there!\nWanna have a swim?";
    }

}
