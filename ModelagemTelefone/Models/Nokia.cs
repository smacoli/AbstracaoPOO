using System;

public class Nokia : Smartphone
{
	public Nokia(string numero, string modelo, string imei, int memoria)
	{
	}

    public override void InstalarAplicativo(string nomeApp)
    {
        Console.WriteLine($"Instalando {nomeApp} no Nokia...");
    }
}
