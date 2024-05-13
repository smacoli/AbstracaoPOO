using System;

public class IPhone : Smartphone
{
	public IPhone(string numero, string modelo, string imei, int memoria)
	{
	}

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no iPhone...");
    }
}
