using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace TestM320
{
  internal class Kind : Person , ILebenserwartung
  {
    //Member
    public Eltern _elternteil1 { get; set; }
    public Eltern _elternteil2 { get; set; }
    private bool _isAdopted;

    //Konstruktor
    public Kind(Eltern elternteil1, Eltern elternteil2) : base(elternteil1._familie)
    {
      //wenn Eltern gleiche Geschlechter haben -> Kind wird adoptiert -> Augenfarbe, Grösse usw wird nicht von den Eltern beeinflusst
      if (elternteil1.getGeschlecht() != elternteil2.getGeschlecht())
      {
        _isAdopted = false;
        Random rand = random;

        //Die Augenfarben, Sehstärken, Hörvermögen und Grösse werden von den Eltern beeinflusst.
        _elternteil1 = elternteil1;
        _elternteil2 = elternteil2;

        //Sehstärke
        byte basis_sehstaerke = rand.Next(0, 2) == 0 ? elternteil1.getSehstaerke() : elternteil2.getSehstaerke();
        byte eltern_sehstaerke_differenz = Convert.ToByte(Math.Abs(elternteil1.getSehstaerke() - elternteil2.getSehstaerke()));
        byte kind_sehstaerke = Convert.ToByte(rand.Next(basis_sehstaerke - eltern_sehstaerke_differenz, basis_sehstaerke + eltern_sehstaerke_differenz));
        if (kind_sehstaerke > 100 || kind_sehstaerke < 0)
          kind_sehstaerke = Convert.ToByte(kind_sehstaerke > 100 ? 100 : 0);
        base.setSehstaerke(kind_sehstaerke);

        //augenfarbe
        string kind_augenfarbe = elternteil1.getAugenfarbe() == elternteil2.getAugenfarbe() ? elternteil1.getAugenfarbe() : (rand.Next(0, 2) == 0 ? elternteil1.getAugenfarbe() : elternteil2.getAugenfarbe());
        base.setAugenfarbe(kind_augenfarbe);

        //hörvermögen
        byte basis_hoervermoegen = rand.Next(0, 2) == 0 ? elternteil1.getHoervermoegen() : elternteil2.getHoervermoegen();
        byte eltern_hoervermoegen_differenz = Convert.ToByte(Math.Abs(elternteil1.getSehstaerke() - elternteil2.getSehstaerke()));
        byte kind_hoervermoegen = Convert.ToByte(rand.Next(basis_hoervermoegen - eltern_hoervermoegen_differenz, basis_hoervermoegen + eltern_hoervermoegen_differenz));
        if (kind_hoervermoegen > 100 || kind_hoervermoegen < 0)
          kind_hoervermoegen = Convert.ToByte(kind_hoervermoegen > 100 ? 100 : 0);
        base.setHoervermoegen(kind_hoervermoegen);

        //Grösse
        float basis_groesse = rand.Next(0, 2) == 0 ? elternteil1.getGroesse() : elternteil2.getGroesse();
        float eltern_groesse_differenz = Convert.ToByte(Math.Abs(elternteil1.getGroesse() - elternteil2.getGroesse()));
        float min = basis_groesse - eltern_groesse_differenz, max = basis_groesse + eltern_groesse_differenz;
        float kind_groesse = rand.Next((int)min * 10, (int)max * 10) / 10;
        base.setGroesse(kind_groesse);
      }
      else
      {
        _isAdopted = true;
      }
    }

    //Methods
    public bool getIsAdopted()
    {
      return _isAdopted;
    }

    //Interface
    public void LebenserwartungMenschen()
    {
        int LebenszeitKinder = random.Next(50, 120);
    }

    //Datenausgabe
    public override void Datenausgabe()
    {
            int LebenszeitKinder = random.Next(50, 120);
            Console.Write($"ist adoptiert: {getIsAdopted()}, Lebenserwartung: {LebenszeitKinder} Jahre, ");
      base.Datenausgabe();
    }

  }
}
