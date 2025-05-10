using UnityEngine;

[CreateAssetMenu(menuName ="Animal/Lion",fileName ="Lion")]
public class LionFactory : AnimalFactory
{
    IAnimal animal;
    public override IAnimal CreateAnimal()
    {
        if (animal == null)
        {
            animal = new Lion();
        }
        return animal;
    }
}
