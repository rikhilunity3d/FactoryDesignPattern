using UnityEngine;

public abstract class AnimalFactory : ScriptableObject{
    public abstract IAnimal CreateAnimal();
}
