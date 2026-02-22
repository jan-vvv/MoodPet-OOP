using UnityEngine;
using UnityEngine.AI;

public abstract class BasePet : MonoBehaviour
{
    //encapsulation
    [SerializeField] private float hunger=50f;
    [SerializeField] private float happiness=50f;
    [SerializeField] private float energy=50f;
    
//Getters and Setters --encap req
public float Hunger
    {
        get{return hunger; }
        protected set{ hunger =Mathf.Clamp(value,0f,100f); }
    }
public float Happiness
    {
        get{return happiness; }
        protected set{ happiness =Mathf.Clamp(value,0f,100f); }
    }
    
public float Energy
    {
        get{return energy; }
        protected set{ energy =Mathf.Clamp(value,0f,100f); }
    }
    //Abstraction:High-level method hiding complexity

    public void UpdateNeedsOverTime()
{
     IncreaseHunger(5f * Time.deltaTime);
     DecreaseEnergy( 3f*Time.deltaTime);
     UpdateMood();
    
}
//Internal logic(hidden from GameManger)
protected void IncreaseHunger(float amount)
    {
        Hunger +=amount;
    }
 protected void DecreaseEnergy(float amount)
    {
      Energy-= amount;
    }
public virtual void Feed()
    {
        Hunger-=20f;
        Happiness+=5f;
    }
public virtual void Play()
    {
        Happiness+=20f;
        Energy-=15f;
        Hunger+=10f;
    }
public virtual void Sleep()
    {
        Energy+=25f;
        Hunger+=5f;
    }
 // Mood System (Abstraction)
public string GetMood()
    {
        if (Energy < 20f) return "Exhausted 😴";
        if (Happiness > 70f) return "Happy 😄";
        if (Happiness < 30f) return "Sad 😢";
        return "Neutral 😐";
    }

    // Placeholder for mood updates (expand later)
    protected void UpdateMood()
    {
        // Can be expanded later for animations or visuals
    }
}

