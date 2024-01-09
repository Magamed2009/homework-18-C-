public class Country
{
    private string Name;
    private string Capital;
    private int Population;
    private string OfficialLanguage;
    public string name { get{return Name;} set{Name = value;} }
    public string capital { get{return Capital;} set{Capital = value;} }
    public int population { get{return Population;} set{Population = value;} }
    public string officialLanguage { get{return OfficialLanguage;} set{OfficialLanguage = value;} }
    public Country(string name,string capital,int population,string officialLanguage)
    {
        this.name = name;
        this.capital = capital;
        this.population = population;
        this.officialLanguage = officialLanguage;
    }
    public void SetCapital(string capital)
    {
        this.capital = capital;
    }
    public string GetCapital()
    {
        return capital;
    }
    public void SetPopulation(int population)
    {
        this.population = population;
    }
    public int GetPopulation()
    {
        return population;
    }
    public void SetOfficialLanguage(string language) 
    {
        this.officialLanguage = officialLanguage;
    }
    public string GetOfficialLanguage() 
    {
        return officialLanguage;
    }
}