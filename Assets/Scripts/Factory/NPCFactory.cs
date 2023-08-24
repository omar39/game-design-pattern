using UnityEngine;

public class NPCFactory : MonoBehaviour
{
   public GameObject GetNPC(NPCType type, Vector3 pos)
   {
        INPC npc;
        GameObject character;
        switch(type)
        {
            case NPCType.Farmer:
                character = Instantiate(
                    Resources.Load<GameObject>("Characters/Farmer"),
                    pos, Quaternion.identity);
                npc = character.GetComponent<Farmer>();
                return character;
            case NPCType.Beach:
                character = Instantiate(
                    Resources.Load<GameObject>("Characters/Beach"),
                    pos, Quaternion.identity);
                npc = character.GetComponent<Beach>();
                return character;
            case NPCType.BusinessMan:
                character = Instantiate(
                    Resources.Load<GameObject>("Characters/BusinessMan"),
                    pos, Quaternion.identity);
                npc = character.GetComponent<BusinessMan>();
                return character;
            case NPCType.Casual:
                character = Instantiate(
                    Resources.Load<GameObject>("Characters/Casual"),
                    pos, Quaternion.identity);
                npc = character.GetComponent<Casual>();
                return character;
        }
        return null;
   }
   public enum NPCType
   {
        Farmer,
        BusinessMan,
        Casual,
        Beach
   }
}
