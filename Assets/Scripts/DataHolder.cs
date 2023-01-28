using UnityEngine;
using UnityEngine.UI;
public class DataHolder : MonoBehaviour
{
    public Slider slider;           //Objects reading data from slider and input field
    public InputField input;

    public static string nameInput;  //To convert data types
    public static float speedInput;
   
    public Text playerName;     //To Display values
    public Text playerSpeed;

    
    public void UpdateName() // Get player name from input field
    {
        nameInput = input.text;
        playerName.text = nameInput;
    }

    public void ShowName() // To display the text from the input field
    {
        playerName.text = nameInput;
    }

    public void SetSpeed() // To get speed from slider and change value to string
    {
        
            speedInput = slider.value;
            playerSpeed.text = speedInput.ToString();
        
    }

    public void ShowSpeed() // To display text from slider
    {
        playerSpeed.text = speedInput.ToString();
    }
}



