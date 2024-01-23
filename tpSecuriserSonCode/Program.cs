using System.Xml.Linq;

public class Pilote
{
    private int id;
    private string name;
    private string firstName;
    private string callSign;
    private string rank;
    private int flightTime;

    public int Id { get => id; set => id = value; }
    public string Name { get => Name; set => Name = value; }
    public string FirstName { get => FirstName; set => FirstName = value; }
    public string CallSign { get => CallSign; set => CallSign = value; }
    public string Rank { get => Rank; set => Rank = value; }

    public Pilote() { }

    public Pilote(int id, string name, string firstName)
    {
        this.id = id;
        this.name = name;
        this.firstName = firstName;
    }

    private int AddFlightTime(int addedFlightTime)
    {
        return flightTime += addedFlightTime;
    }

    public void EngagePilot(string callSign, string rank, int flightTime)
    {
        this.callSign = callSign;
        this.rank = rank;
        this.flightTime = flightTime;
    }

    public void MissionComeBack(int duration)
    {
        flightTime = AddFlightTime(duration);
    }
}


internal class Program
{ 
    private static void Main(string[] args)
{
    Console.WriteLine('Saisie Pilote');
        Console.WriteLine("Saisir l'id du pilote");

        int idPilote = int.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("saisir le nom du pilote");
        string nomPilote = Console.ReadLine() ?? "Toto";

        Console.WriteLine("saisir le prenom du pilote");
        string prenomPilote = Console.ReadLine()??"Tata";

        Pilote premierPilote = new Pilote(idPilote, nomPilote, prenomPilote);

        Console.WriteLine("Saisir le callsign du pilote");
        string callSign = Console.ReadLine() ?? "Titi";
        Console.WriteLine("Saisir le grade");
        string grade = Console.ReadLine() ?? "Lieutenant";
        Console.WriteLine("Saisir les heures de vol du pilote");

        premierPilote.EngagePilot(callSign, grade, heureDeVol);

        premierPilote

        Console.Read();
    }
      
}




class avion
{
    public string callsign
    {
        get { return callsign; }
        set { callsign = value; }
    }

    public string type
    {
        get { return type; }
        set { type = value; }
    }

    public string capaciteCarburant
    {
        get { return capaciteCarburant; }
        set { capaciteCarburant = value; }
    }

    public int geopod
    {
        get { return geopod; }
        set { geopod = value; }
    }

    public int pilotPourMission
    {
        get { return pilotPourMission; }
        set { pilotPourMission = value; }
    }

    public Boolean trainAtterrissage
    {
        get { return trainAtterrissage; }
        set { trainAtterrissage = value; }
    }
}