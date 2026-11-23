using UnityEngine;
using TMPro;

public class GameplayScript : MonoBehaviour
{
    [SerializeField]
    public int  keysFound;
    [SerializeField]
    TMP_Text END;

    // Update is called once per frame
    void Update()
    {
        if (keysFound == 3) {
            END.text = "VICTORIA";
        }
    }
}