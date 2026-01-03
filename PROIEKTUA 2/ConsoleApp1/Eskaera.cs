namespace ConsoleApp1;

class Eskaerak
{
     string? Janaria; 
    public string? Menua; 
    public string? Edaria; 
    public string? Edaria_Handia; 
    public string? Edari_Txikia; 
    public string? Izkozkia; 
    public string? Konplementu_Handiak; 
    public string? Konplementu_Txikiak; 
    
    


    public Eskaerak(string? Janaria = null,string? Menua = null, string? Edaria = null,string? Edaria_Handia = null,string? Konplementu_Handiak = null,string? Konplementu_Txikiak = null,string? Edari_Txikia = null,string? Izkozkia = null)
    {
    this.Janaria = Janaria;
    this.Menua = Menua;
    this.Edaria = Edaria;
    this.Edaria_Handia = Edaria_Handia;
    this.Konplementu_Handiak = Konplementu_Handiak;
    this.Konplementu_Txikiak = Konplementu_Txikiak;
    this.Edari_Txikia = Edari_Txikia;
    this.Izkozkia = Izkozkia;
    }



    public string? getJanaria()
    {
        return Janaria;
    }
    public void setJanaria(string? janaria)
    {
        Janaria = janaria;
    }
    public string? getMenua()
    {
        return Menua;
    }
    public void setMenua(string? menua)
    {
        Menua = menua;
    }
    public string? getEdaria()
    {
        return Edaria;
    }
    public void setEdaria(string? edira)
    {
        Edaria = edira;
    }
    public string? getEdaria_Handia()
    {
        return Edaria_Handia;
    }
    public void setEdaria_Handia(string? edari_handia)
    {
        Edaria_Handia = edari_handia;
    }

    public string? getEdari_Txikia()
    {
        return Edari_Txikia;
    }
    public void setEdaria_Txikia(string? edari_Txikia)
    {
        Edari_Txikia = edari_Txikia;
    }

    public string? getIzozkia()
    {
        return Izkozkia;
    }
    public void setIzozkia(string? izokzia)
    {
        Izkozkia = izokzia;
    }
    public string? getKonplementu_Handiak()
    {
        return Konplementu_Handiak;
    }
    public void setKonplementu_Handiak(string? konplementu_Handiak)
    {
        Konplementu_Handiak = konplementu_Handiak;
    }

    public string? getKonplementu_Txikiak()
    {
        return Konplementu_Txikiak;
    }
    public void setKonplementu_Txikiak(string? konplementu_Txikiak)
    {
      Konplementu_Txikiak = konplementu_Txikiak;
    }

        

}
