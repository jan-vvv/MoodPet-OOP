using UnityEngine;
using UnityEngine.SceneManagement;
//system Manager--Handles pet selection and scene transition

public class PetSelectionManager : MonoBehaviour
{
    public static string SelectedPetTypes;
     //called when dogbutton clicked 
     public void SelectDog()
    {
        SelectedPetTypes ="Dog";
        SceneManager.LoadScene("MainPetScene");
    }

    //called when Cat Button is clicked
    public void SelectCat()
    {
        SelectedPetTypes="Cat";
        SceneManager.LoadScene("MainPetScene");
    }
}
