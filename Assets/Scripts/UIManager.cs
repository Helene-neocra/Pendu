using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI textMot;
    public TextMeshProUGUI textMessage;

    public void AfficherMot(string mot)
    {
        textMot.text = mot;
    }

    public void AfficherMessage(string message)
    {
        textMessage.text = message;
    }
}