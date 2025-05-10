//this is product interface but for meaning full naming convention 
// I have given IAnimal name to the interface.
public interface IAnimal
{
    void Sound();

    static IAnimal CreateDefault()
    {
        return new Lion();
    }
}
