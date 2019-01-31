using InternalTest.Dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespace2
{
	internal class Namespace2Class1
	{
		internal string Name { get; set; }
		internal string Surname { get; set; }
		internal string City { get; set; }

		// 'Namespace2' isimli namespace altından 'InternalTest.Dll' isimli namespace altındaki 'Musteri' sınıfına da using kısmına 'using InternalTest.Dll;' ekledikten sonra erişebiliyorum.
		public Musteri Musteri { get; set; }
	}
}

/* Not; Bu kodları yazarken yeni fark ettim 
* Eğer buradaki 'Namespace2' namespace adı yerine 'InternalTest.Dll.Namespace1' şeklinde bir namespace adı kullansaydım using bloğuna 'Musteri' sınıfını kullanmak için
* 'using InternalTest.Dll;' eklemem gerekmiyecekti.
* Galiba .net'ti yazanlar isim hiyerarşisi mantıklı şekilde yapılınca daha detaylı namespace'ler içinden
* isimlendirme olarak daha az kapsamlı olan namespace altındaki elemanlara(class, enum, struct) erişim için using kısmına erişilmek istenen namespace'lerin eklenmesini gerekli kılmıyor.
* 
* Örnek vermek gerekirse 'Namespace2' namespace adını 'InternalTest.Dll.Namespace2' şeklinde değiştirince using bloğuna 'using InternalTest.Dll;' değerini eklemek gerekmiyor.
* 
*/
