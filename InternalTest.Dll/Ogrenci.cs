using InternalTest.Dll.Namespace1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalTest.Dll
{
	public class Ogrenci
	{
		public int id { get; set; }
		public string isim { get; set; }
		public string soyisim { get; set; }
		internal int internalField { get; set; }

		// 'Namespace1Class1' isimli bu sınıf internal tanımlı ve namespace değeri 'InternalTest.Dll.Namespace1' ve bu namespace altındaki sınıfa başka bir namespace altından,
		// ki o ' InternalTest.Dll' isimli namespace erişilebiliyor.
		// Burada using kısmına 'using InternalTest.Dll.Namespace1;' değerini ekledikten sonra tabiki.
		internal Namespace1Class1 InternalClass { get; set; } 
	}
}
