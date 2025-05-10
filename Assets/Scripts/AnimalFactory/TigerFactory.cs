using UnityEngine;

[CreateAssetMenu(menuName ="Animal/Tiger",fileName ="Tiger")]
public class TigerFactory : AnimalFactory
{
    IAnimal animal;
    public override IAnimal CreateAnimal()
    {
        if (animal == null)
        {
            animal = new Tiger();
        }
        return animal;
    }
}
