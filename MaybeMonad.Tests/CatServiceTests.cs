using MaybeMonad.API.Services;

namespace MaybeMonad.Tests;

public class CatServiceTests
{
    private CatService _catService;
    
    [SetUp]
    public void Setup()
    {
        _catService = new CatService();
    }

    [Test]
    public void givenCatExists_whenRetrieveCatName_returnCatName()
    {
        //arrange
        var expectedCat = new CatService.Cat(1, "Bumble");

        //act
        var result = _catService.retrieveCat(1);

        //assert
        Assert.AreEqual(expectedCat, result.Value);
        Assert.AreEqual(true, result.HasValue);


    }
    
    [Test]
    public void givenCatDoesntExist_whenRetrieveCat_returnMaybe()
    {
        //arrange

        //act
        var result = _catService.retrieveCat(4);
        
        //assert
        Assert.AreEqual(true, result.HasNoValue);
        Assert.NotNull(result);
    }
}