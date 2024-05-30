
namespace E1;

public class FullName
{
    public string FirstName;
    public string LastName;

    public FullName(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public override bool Equals(object? obj)
    {
        if(obj is not FullName)
        {
            return false;
        }
        else
        {
            return (this.FirstName == (obj as FullName).FirstName) && (this.LastName == (obj as FullName).LastName);
        }
    }

    #region TODO
    #endregion
}

public static partial class Basics
{
    public static void RemoveDuplicates<T>(ref T[] list)
    {
        List<T> newList = new List<T>();
        foreach (var item in list)
        {
            if (!Contains(newList, item))
                newList.Add(item);
        }
        list = newList.ToArray();
    }

    private static bool Contains<T>(List<T> list, T lookup)
    {
        foreach (var item in list)
            if (item.Equals(lookup))
                return true;
        return false;
    }
}
