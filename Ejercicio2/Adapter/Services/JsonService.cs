using System;
using Ejercicio2.Adapter.Interfaces;

namespace Ejercicio2.Adapter.Services
{
	public class JsonService : IMapFormat

	{
        public string jsonMap()
        {
            return "Mapeando datos con Json";
        }
    }
}

