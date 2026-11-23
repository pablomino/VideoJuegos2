using UnityEngine;
using TMPro;

public class MutantDetection : MonoBehaviour
{
    [SerializeField]
    TMP_Text END;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            END.text = "Has sido visto. FIN";
        }
    }
}
