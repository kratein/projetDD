using System;

public class De
{    
	public De()
	{
    }
    public int Lancer(int nbrDe, int nbrFace)
    {      
        Random de = new Random();
        return de.Next(nbrDe, (nbrFace*nbrDe) + 1);
    }
}
