namespace MaybeMonad.API.Services;

public class CatService
{
    private List<Cat> cats()
    {
        return new List<Cat> { new(1, "Bumble"), new(2, "Kit"), new(3, "Sky") };
    }

    public Maybe<Cat> retrieveCat(int id)
    {
        return cats().FirstOrDefault(x => x.Id == id);
    }

    public class Cat
    {
        public Cat(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }

        public string Name { get; }
    }
}