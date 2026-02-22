using UnityEngine;
//inheritence 
public class DogPet : BasePet
{
    //polymorphism
    public override void Play()
    {
        Happiness+=30f;
        Energy-=15f;
        Hunger+=10f;

        Debug.Log("Dog is playing happily!");
    }
    public override void Feed()
    {
        //happy when
        Hunger-=25f;
        Happiness+=15f;
        Debug.Log("Dog enjoyed the food! 🍖");
    }

    public override void Sleep()
    {
        Energy +=30f;
        Hunger+=5f;

        Debug.Log("Dog is sleeping... 💤");
    }
}
