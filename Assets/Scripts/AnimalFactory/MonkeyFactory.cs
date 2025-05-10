using UnityEngine;

[CreateAssetMenu(menuName ="Animal/Monkey",fileName ="Monkey")]
public class MonkeyFactory : AnimalFactory
{
    IAnimal animal;
    public override IAnimal CreateAnimal()
    {
        if (animal == null)
        {
            animal = new Monkey();
        }
        return animal;
    }
}
