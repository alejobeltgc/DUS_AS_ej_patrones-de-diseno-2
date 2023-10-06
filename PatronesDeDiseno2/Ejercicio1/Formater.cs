using System;
namespace PatronesDeDiseno2.Ejercicio1
{
	public class Formater
	{
		private IFormatStrategy _strategy;

        public Formater(IFormatStrategy strategy)
		{
			this._strategy = strategy;
		}


        public void setStrategy(IFormatStrategy strategy)
		{
			this._strategy = strategy;
		}

		public string formatDocument(string api)
		{
			string data = _strategy.getData(api);
			string calcData = _strategy.calc(data);
			return _strategy.format(calcData);
		}
	}
}

