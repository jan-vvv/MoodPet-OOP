using UnityEngine;

//SPAWNER--demonstrates polymorphism via dynamic instantiation
public class PetSpawner : MonoBehaviour
{
    [SerializeField]private GameObject dogPrefab;
    [SerializeField]private GameObject catPrefab;
    void Start()
    {
        SpawnSelectedPet();
    }
 private void SpawnSelectedPet()
    {
        string petType= PetSelectionManager.SelectedPetTypes;
        if(petType == "Dog")
        {
            Instantiate(dogPrefab,Vector3.zero,Quaternion.identity);
        }
        else if (petType == "Cat")
        {
            Instantiate(catPrefab,Vector3.zero,Quaternion.identity);
        }
        else
        {
            //default fallback
            Instantiate(dogPrefab,Vector3.zero,Quaternion.identity);
        }
    }
    // Update is called once per frame

}
