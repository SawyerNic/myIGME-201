namespace Hobbies;

public abstract class Sports
{
    public string equipment;

    public abstract int BuyEquipment
    {
        get;
        set;
    }

    public virtual void Play()
    {

    }
}

public class Soccer : Sports, SoccerField
{
    private int cleats;

    public override int BuyEquipment
    {
        get { return cleats; }
        set { cleats = value; }
    }
}

public class Lacrosse : Sports, LacrosseField
{
    private int stick;

    public override int BuyEquipment
    {
        get { return stick; }
        set { stick = value; }
    }
}

public interface SoccerField
{

}

public interface LacrosseField
{

}