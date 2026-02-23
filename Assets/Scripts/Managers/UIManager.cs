using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class UIManager : MonoBehaviour
{
   [Header("Pet Refrence")]
   [SerializeField] private BasePet currentPet;

   [Header("UI Sliders")]
   [SerializeField] private Slider hungerSlider;
   [SerializeField] private Slider happinessSlider;
   [SerializeField] private Slider energySlider;

   [Header("Mood Text")]
   [SerializeField] private TextMeshProUGUI moodText;
   private void Update()
    {
        if(currentPet==null) return;
        UpdateSliders();
        UpdateMoodText();
    }

    private void UpdateSliders()
    {
        hungerSlider.value=currentPet.Hunger;
        happinessSlider.value=currentPet.Happiness;
        energySlider.value= currentPet.Energy;
    }

private void UpdateMoodText()
    {
        moodText.text="Mood:"+currentPet.GetMood();
    }

}
