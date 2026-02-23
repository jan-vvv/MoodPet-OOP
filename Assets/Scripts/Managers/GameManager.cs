using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private BasePet currentPet;
    [Header("Time Settings")]
    [SerializeField] private float decayInterval =1f;
    private float timer;

    private void Update()
    {
        HandlePetNeeds();
    } 
    //abstraction 
    private void HandlePetNeeds()
    {
        if(currentPet==null) return;

        timer+=Time.deltaTime;
        if(timer>=decayInterval)
        {
            currentPet.UpdateNeedsOverTime();
            timer=0f;
        }
    }
    //button functions (connected to ui)
    public void FeedPet()
    {
        if (currentPet != null)
        {
            currentPet.Feed();
        }
    }
     public void PlayWithPet()
    {
        if (currentPet != null)
        {
            currentPet.Play();
        }
    }

    public void PutPetToSleep()
    {
        if (currentPet != null)
        {
            currentPet.Sleep();
        }
    }
}
