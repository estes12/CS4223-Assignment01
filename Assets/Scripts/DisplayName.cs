using UnityEngine;
using UnityEngine.UI;
public class DisplayName : MonoBehaviour
{
    public Text playerName;

    // Start is called before the first frame update
    void Start()
    {
        playerName.text = DataHolder.nameInput;
    }
}
