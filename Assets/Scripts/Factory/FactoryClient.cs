using UnityEngine;
using System.Collections;
public class FactoryClient : MonoBehaviour
{
    [SerializeField] private Transform spawiningPoint;
    [SerializeField] private Transform standingPoint;
    [SerializeField] private float npcSpeed = 5f;
    private NPCFactory npcFactory = new NPCFactory();
    private GameObject currentNPC;
    void Start()
    {
        SpawnNPCs();
    }
    void SpawnNPCs()
    {
        //Get a random NPC
        System.Array values = System.Enum.GetValues(typeof(NPCFactory.NPCType));
        System.Random random = new System.Random();
        NPCFactory.NPCType type = (NPCFactory.NPCType) values.GetValue(random.Next(values.Length));

        currentNPC = npcFactory.GetNPC(type, spawiningPoint.position);

        StartCoroutine( MoveNPCToStandingPoint() );
    }
    bool CheckArrivalToTarget()
    {
        Vector3 currPos = currentNPC.transform.position;
        currentNPC.transform.position = Vector3.MoveTowards(currPos, standingPoint.position, npcSpeed * Time.deltaTime);
        return Vector3.Distance(currentNPC.transform.position, standingPoint.position) < 0.1f;
    }
    IEnumerator MoveNPCToStandingPoint()
    {
        currentNPC.transform.LookAt(standingPoint);
        currentNPC.GetComponent<CharacterAnimatorManager>().Walk();
        
        yield return new WaitUntil( () => CheckArrivalToTarget() );

        currentNPC.GetComponent<CharacterAnimatorManager>().Walk(false);

        currentNPC.GetComponent<INPC>().Speak();
        currentNPC.GetComponent<CharacterAnimatorManager>().Wave();
    }

    public void GetNextNPC()
    {
        Destroy(currentNPC);
        SpawnNPCs();
    }
}
