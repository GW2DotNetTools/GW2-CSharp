#region Achievement
public void GetASingleAchievement()
{
    Achievement achievement = GW2Api.V2().Achievements.Get(10);
}

public void GetASingleAchievementInASpecificLanguage()
{
    RequestedLanguage language = RequestedLanguage.de;
    Achievement achievement = GW2Api.V2().Colors.GetById(10, language);
}

public void GetAllAchievements()
{
    Dictionary<int, Lazy<Achievement>> allAchievements = GW2Api.V2().Achievements.GetAll();
}

public void GetMultipleAchievements()
{
    Dictionary<int, Lazy<Achievement>> multipleAchievements = GW2Api.V2().Achievements.GetMultiple(language, 10, 20, 40);
}
#endregion

#region Color
public void GetASingleColor()
{
    Color skyColor = GW2Api.V2().Colors.GetById(10);
}

public void GetASingleColorInASpecificLanguage()
{
    RequestedLanguage language = RequestedLanguage.de;
    Color skyColor = GW2Api.V2(language).Colors.GetById(10);
}

public void GetAllColors()
{
    Dictionary<int, Lazy<Color>> allColors = GW2Api.V2().Colors.GetAll();
    Color skyColor = allColors[10].Value;
}
#endregion

#region Commerce/Exchange/Coins
public void GetValueOfCoinsInGems()
{
    Coin coinFromRawApiMoney = GW2Api.V2().Exchanges.GetCoin(new Money(10000));
    Coin coinFromClass = GW2Api.V2().Exchanges.GetCoin(new Money(10, 50, 2)); //2g 50s 10c
}

public void GetValueOfGemInCoins()
{
    Gem gem = GW2Api.V2().Exchanges.GetGem(100);
}
#endregion

#region Continents
public void GetAllContinents()
{
    IEnumerable<Continent> continents = GW2Api.V2().Continents.GetAll();
}

public void GetASpecificContinent()
{
    Continent continent = GW2Api.V2().Continents.GetById(1);
}
#endregion

#region Currencies
public void GetACurrency()
{
    Currency gem = GW2Api.V2().Currencies.Get(CurrencyType.Gem);
}

public void GetACurrencyInASpecificLanguage()
{
    RequestedLanguage language = RequestedLanguage.de;
    Currency gem = GW2Api.V2(language).Currencies.Get(CurrencyType.Gem);
}
#endregion

#region Maps
public void GetAllMaps()
{
    IEnumerable<Lazy<Map>> maps = GW2Api.V2().Maps.GetAll();
}

public void GetMapInSpecificLanguage()
{
    Map map = GW2Api.V2(RequestedLanguage.De).Maps.GetById(50);
}
#endregion

#region PvpGame
public void GetRecentGames()
{
    string token = "58751B23-07DA-AB49-A5DE-0DBC9BA6C79ECCDE107E-2785-4296-BAEF-64AD20580F8A";
    IEnumerable<PvpGame> games = GW2Api.V2(token).PvpGame.GetRecent();
}
#endregion

#region PvpStatistics
public void GetStatistics()
{
    string token = "58751B23-07DA-AB49-A5DE-0DBC9BA6C79ECCDE107E-2785-4296-BAEF-64AD20580F8A";
    PvpStatistic statistic = GW2Api.V2(token).PvpStatistics.Get();
}
#endregion

#region Quaggan
public void GetAQuaggan()
{
    Quaggan cakeQuaggan = GW2Api.V2().Quaggans.Get("cake");
}

public void GetQuagganImage()
{
    Bitmap cakeQuagganImage = GW2Api.V2().Quaggans.Get("cake").GetImage();
}

public void GetAllQuaggans()
{
    IEnumerable<Lazy<Quaggan>> quaggans = GW2Api.V2().Quaggans.GetAll();
}
#endregion

#region RenderService
public void RenderAIcon()
{
    const string signature = "943538394A94A491C8632FBEF6203C2013443555";
    const string fileId = "102478";
    Bitmap bitmap = RenderService.GetImage(signature, fileId, FileFormat.png);
}
#endregion

#region RessourceFile
public void GetASingleREssourceFile()
{
    RessourceFile ressourceFile = GW2Api.V2().RessourceFiles.Get("map_heropoint");
}

public void GetMultipleRessourceFiles()
{
    IEnumerable<RessourceFile> ressourceFiles = GW2Api.V2().RessourceFiles.GetMultiple("map_heropoint", "wvw_battles_hollow_green");
}

public void GetAllRessourceFiles()
{
    IEnumerable<RessourceFile> ressourceFiles = GW2Api.V2().RessourceFiles.GetAll();
}
#endregion

#region Skins
public void GetAllSkins()
{
    Dictionary<int, Lazy<Skin>> skins = GW2Api.V2().Skins.GetAll();
    Skin adeptHelm = skins[263].Value;
}

public void GetSkinInSpecificLanguage()
{
    Skin skin = GW2Api.V2(RequestedLanguage.De).Skins.GetById(1);
}
#endregion

#region Tokeninfo
public void GetTokeninfo()
{
    string testAccountToken = "58751B23-07DA-AB49-A5DE-0DBC9BA6C79ECCDE107E-2785-4296-BAEF-64AD20580F8A";
    Tokeninfo token = GW2Api.V2(testAccountToken).Get();
}
#endregion

#region V2Endpoint
public void GetBuildId()
{
    int buildId = GW2Api.V2().GetBuildId;
}
#endregion

#region Worlds
public void GetAWorld()
{
    World pikenSquare = GW2Api.V2().Worlds.GetById(2012);
}

public void GetMultipleWorldsWithLanguage()
{
    RequestedLanguage language = RequestedLanguage.de;
    IEnumerable<World> worlds = GW2Api.V2(language).Worlds.GetById(1001, 2012);
}

public void GetAllWorlds()
{
    IEnumerable<World> allWorlds = GW2Api.V2().Worlds.GetAll();
}
#endregion