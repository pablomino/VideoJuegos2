using UnityEngine;
using TMPro;

public class KeyScript : MonoBehaviour
{
    [SerializeField]
    GameplayScript script;    
    [SerializeField]
    TMP_Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            script.keysFound++;
            text.text = "Llaves "+script.keysFound+"/3";
            Destroy(gameObject, 1f);
        }
    }
}