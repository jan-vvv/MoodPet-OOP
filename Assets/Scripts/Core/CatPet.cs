using UnityEngine;

// CHILD CLASS → Demonstrates INHERITANCE
public class CatPet : BasePet
{
    // POLYMORPHISM → Different behavior than Dog
    public override void Play()
    {
        // Cats play less but use less energy
        Happiness += 20f;
        Energy -= 8f;
        Hunger += 6f;

        Debug.Log("Cat is playing lazily 🐱");
    }

    public override void Feed()
    {
        // Cats are picky eaters
        Hunger -= 20f;
        Happiness += 8f;

        Debug.Log("Cat ate the food calmly 🍣");
    }

    public override void Sleep()
    {
        // Cats recover more energy (sleep masters)
        Energy += 40f;
        Hunger += 8f;

        Debug.Log("Cat is sleeping deeply 😴");
    }
}