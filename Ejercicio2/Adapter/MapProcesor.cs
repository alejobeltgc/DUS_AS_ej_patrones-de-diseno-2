using System;
using Ejercicio2.Adapter.Interfaces;

namespace Ejercicio2.Adapter
{
	public class MapProcesor
	{
		private IMapFormat _mapService;

        public MapProcesor(IMapFormat mapService)
		{
			this._mapService = mapService;
		}

        public string data()
		{
			return _mapService.jsonMap();
		}
    }
}

