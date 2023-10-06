using System;
namespace PatronesDeDiseno2.Ejercicio1
{
	public interface IFormatStrategy
	{
		string getData(string api);
		string calc(string data);
		string format(string calcData);
	}
}

