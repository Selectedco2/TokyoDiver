/*====================================================================================================
    Declared variables
====================================================================================================*/
string DefaultName = "Jack";

// your bestfriend (crush on you)
Girl asuka = new Girl();
asuka.name = "Asuka";
asuka.affection = 2;

// cosplaying shy girl
Girl mai = new Girl();
mai.name = "Mai";
mai.affection = 0;

// nerdy library girl
Girl akane = new Girl();
akane.name = "Akane";
akane.affection = 0;

// stern independet girl
Girl maiko = new Girl();
maiko.name = "Maiko";
maiko.affection = -1;


/*====================================================================================================
    Gamestart
====================================================================================================*/






/*====================================================================================================
    Klasser
====================================================================================================*/

class Girl
{
    public string name;
    public int affection;

}