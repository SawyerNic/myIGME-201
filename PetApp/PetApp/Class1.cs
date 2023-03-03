using System;

//Pets class
public class Pets
{

    //Holds list of all pets
    List<Pet> petList = new List<Pet>();

    //properties
    public Pet this[int nPetEl]
    {
        get
        {
            Pet returnVal;
            try
            {
                returnVal = (Pet)petList[nPetEl];
            }
            catch
            {
                returnVal = null;
            }

            return (returnVal);
        }

        set
        {
            // if the index is less than the number of list elements
            if (nPetEl < petList.Count)
            {
                // update the existing value at that index
                petList[nPetEl] = value;
            }
            else
            {
                // add the value to the list
                petList.Add(value);
            }
        }


    }
    public void Add(Pet pet)
    {
        petList.Add(pet);
    }

    public void Remove(Pet pet)
    {
        petList.Remove(pet);
    }

    public void RemoveAt(int petEl)
    {
        petList.RemoveAt(petEl);
    }

    public int Count
    {
        get
        {
            return petList.Count;
        }
    }


}

public abstract class Pet : IComparable<Pet>
{
    //local varaibles
    public string name = "";
    public int age = 0;

    //methods
    public abstract void Eat();
    public abstract void Play();
    public abstract void GotoVet();

    //instances
    public Pet()
    {

    }

    public Pet(string name, int age)
    {
        this.name = name;
        this.age = age;
    }


    //Comparable method
    public int CompareTo(Pet pet)
    {
        return this.name.CompareTo(pet.name);
    }


}

//cat interface
public interface ICat
{
    //methods
    public void Eat()
    {

    }

    public void Play()
    {

    }

    public void Scratch()
    {

    }

    public void Purr()
    {

    }
}

public interface IDog
{
    //methods
    public void Eat()
    {

    }

    public void Play()
    {

    }

    public void Bark()
    {

    }

    public void NeedWalk()
    {

    }

    public void GotoVet()
    {

    }

}

//cat class
public class Cat : Pet, ICat
{
    //methods (override)
    public override void Eat()
    {

    }

    public override void Play()
    {

    }

    public override void GotoVet()
    {

    }

    //methods
    public void Purr()
    {

    }

    public void Scratch()
    {

    }
}

//dog class
public class Dog : Pet, IDog
{
    //locals
    public string license = "";

    //methods (override)
    public override void Eat()
    {

    }

    public override void GotoVet()
    {

    }

    public override void Play()
    {

    }

    //methods
    public void Bark()
    {

    }

    public void NeedWalk()
    {

    }
}


