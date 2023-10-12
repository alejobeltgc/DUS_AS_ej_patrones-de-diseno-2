using System;
using Ejercicio2.Adapter.Interfaces;
using Ejercicio2.Adapter.Services;

namespace Ejercicio2.Adapter.Adapters
{
	public class KmlAdapter : IMapFormat
	{
		private KmlService _kmlService;

		public KmlAdapter(KmlService kmlService)
		{
			this._kmlService = kmlService;
		}

        public string jsonMap()
        {
			return _kmlService.generateMap() + "Adaptada al formato JSON";
        }
    }
}

